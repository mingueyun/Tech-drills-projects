#!/usr/bin/python
# -*- coding: utf-8 -*-

# Python Ver:   3.5.1
#
# Author:       Min K Yun
#
# Purpose:      running datetime time zone drill

import datetime
from datetime import *
from pytz import timezone
##import pytz
##import time

#### i started with this just to get the correct timezones for each locatin
##fmt = "%Y-%m-%d %H:%M:%S"
##portland = timezone('US/Pacific')
##nyc = timezone('US/Eastern')
##london = timezone('Europe/Berlin')
##port_time = datetime.now(portland)
##nyc_time = datetime.now(nyc)
##london_time = datetime.now(london)
##print (port_time.strftime(fmt))
##print (nyc_time.strftime(fmt))
##print (london_time.strftime(fmt))

# I built this last cause i could not figure out how to call on each function without makeing other functions so i
# made this so that the code was minimal and not complex. It just required an input so that i can pass on the the function it selected for the office to contact.
# i guess i didnt have to build  the local office this way but I found a solution using the easy way out.
def openOrClosed(): 
    contact = input('want to contact the new branches?  choose Y to contact all branches  or N   y/n:')
    if contact == 'y':
         eastCoastOffice()
         EuropeLondonOffice()
         localOffice()
    if contact == 'n':  
        print ('then you have a good day')
##    contact = raw_input('want to contact the new branches?  choose 1 for NYC or 2 for London or 3 for HQ 1/2/3:')
##    if contact == '1':
##        eastCoastOffice()
##    if contact == '2':
##        EuropeLondonOffice()
##    if contact == '3':
##        localOffice()    

# i  built functions for each office and printed out just to make sure that it would correctly get the time
# and compare the time for opening.
def localOffice():
    portland = timezone('US/Pacific')
    port_current = datetime.now(portland)
    port_time = port_current.strftime("%H:%M:%S")
    print( 'The current time here in portland is: ', port_time)
    if port_current.hour > 9 and  port_current.hour < 21:
        print ('We are open now.Hello! you should be at work!')
    else:
        print ('UMMMM.... we are currently closed so maybe you should go home to your kids now.')
       
def eastCoastOffice():
    nyc = timezone('US/Eastern')
    nyc_current = datetime.now(nyc)
    nyc_time = nyc_current.strftime("%H:%M:%S")
    print ('The current time over in the New York Office is: ', nyc_time)
    if nyc_current.hour > 9 and  nyc_current.hour < 21:
        print ('The new NYC branch is currently open. ')
    else:
        print('The new NYC branch is currently closed.')
def EuropeLondonOffice():
    london = timezone('Europe/London')
    london_current = datetime.now(london)
    london_time = london_current.strftime("%H:%M:%S")
    print ('The current time overseas at the London office is: ', london_time)
    if london_current.hour > 9 and  london_current.hour < 21:
        print ('The new London branch is currently open. ')
    else:
        print ('The new London branch is currently closed.')

openOrClosed()

