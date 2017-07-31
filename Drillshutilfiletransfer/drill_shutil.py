#!/usr/bin/python
# -*- coding: utf-8 -*-

# Python Ver:   3.5.1
#
# Author:       Min K Yun
#
# Purpose:      running shutil drills


## i used to too trouble shoot the problem but i think it had to do with python not working
##import shutil 
##def copyFile(src, dest):
##
##    try:
##        shutil.copy(src, dest)
##    # eg. src and dest are the same file
##    except shutil.Error as e:
##        print('Error: %s' % e)
##    # eg. source or destination doesn't exist
##    except IOError as e:
##        print('Error: %s' % e.strerror)
##src ='C:\\Users\\Min Kyu\\Desktop\\A\\AA.txt'
##dest ='C:\\Users\\Min Kyu\\Desktop\\B'        
##copyFile(src, dest)
import os
import shutil

src = 'C:\\Users\\Min Kyu\\Desktop\\HoldDaily'
dst = 'C:\\Users\\Min Kyu\\Desktop\\CopiedDaily' 
for file in os.listdir(src):
    print (file)  
    src_file = os.path.join(src, file)
    dst_file = os.path.join(dst, file)
    shutil.copy(src_file, dst_file)
