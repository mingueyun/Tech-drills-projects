#!/usr/bin/python
# -*- coding: utf-8 -*-

# Python Ver:   3.5.1
#
# Author:       Min K Yun
#
# Purpose:      drill for Daily file tranfer



import Dog_event_watch


import time
import os
import shutil

SECONDS_IN_DAY = 24 * 60 * 60

src = 'C:/Users/Min Kyu/Desktop/A'
dst = 'C:/Users/Min Kyu/Desktop/B'


now = time.time()
before = now - SECONDS_IN_DAY

def last_mod_time(dst):
    return os.path.getmtime(src)

for file in os.listdir(src):
    print(file)
    src_file = os.path.join(src, file)
    if last_mod_time(src_file) > before:
        dst_file = os.path.join(dst, file)
        shutil.move(src_file, dst_file)

last_mod_time(dst)




if __name__ == "__main__":
    pass



