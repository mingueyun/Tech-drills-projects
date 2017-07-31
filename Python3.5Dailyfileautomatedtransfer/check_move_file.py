#!/usr/bin/python
# -*- coding: utf-8 -*-

# Python Ver:   3.5.1
#
# Author:       Min K Yun
#
# Purpose:      drill for Daily file tranfer


import os
import shutil
import time
import datetime
import sqlite3

import gui_file_transfer



def makedb():
    connection = sqlite3.connect('file_checker.db')
    with connection:
        c = connection.cursor()
        c.execute("CREATE TABLE IF NOT EXISTS TimeStamp(check_time DATE)")
        c,count = count_records(c)
        if count < 1: 
            c.execute("INSERT INTO TimeStamp(check_time) VALUES(?)",(datetime.datetime.now(),))
            connection.commit()
    connection.close()
    

def fill_stuff():    
    realTime = datetime.datetime.now()
    connection = sqlite3.connect('file_checker.db')
    with connection:
        c = connection.cursor()
        c,count = count_records(c)
        c.execute("INSERT INTO TimeStamp(check_time) VALUES(?)",(realTime,))
        connection.commit()

    
def count_records(c):
    count = "" 
    c.execute("""SELECT COUNT(*) FROM TimeStamp""")
    count = c.fetchone()[0] 
    return c,count
    

def fwd_tmstmp():
    connection = sqlite3.connect('file_checker.db')
    c = connection.cursor()
    last_check = c.execute("SELECT check_time  FROM TimeStamp WHERE ROWID = (SELECT MAX(ROWID) FROM TimeStamp)")
    for row in c.fetchone():
        return (row)
    connection.close()
    

def moveModFiles(src, dst):    
    changed_file = os.listdir(src)
    for file_name in changed_file:
        change_time = os.path.getmtime(src+file_name)
        check_time = time.time() - 86400
        if change_time >= check_time:
            shutil.move(src+file_name, dst)
            print (file_name + " has been moved to: " + os.path.abspath(dst+file_name))
    fill_stuff()  
   




