#!/usr/bin/python
# -*- coding: utf-8 -*-
#
# Python Ver:   3.5.1
#
# Author:       Min yun
#
# Purpose:      gui for file Transfer.


import tkinter
from tkinter import *
from tkinter import ttk
import os
import shutil
import time

import check_move_file

class DailyMover:

    def __init__(self, master):
        

        master.title('Move Your Modified Files')
        master.resizable(False,False)

        self.frame_header = ttk.Frame(master)
        self.frame_header.pack()
        ttk.Label(self.frame_header, text = 'Select source then the desitnation folder!').grid(row = 0, column = 0)
        ttk.Label(self.frame_header, text = (" Then select Move Files  that have been modified within the last 24 hours since the last file move.........")).grid(row = 1, column = 0)                  
                                                 
        self.frame_content = ttk.Frame(master)
        self.frame_content.pack()

        ttk.Button(self.frame_content,width=30, text='Select Source Folder', command= lambda: self.getSourceFolder()).grid(row=0, column=0, padx=10, pady=10,sticky = 'w',)
        ttk.Button(self.frame_content,width=30, text='Select Destination Folder', command= lambda: self.getDestFolder()).grid(row=1, column=0, padx=10, pady=10)
        ttk.Button(self.frame_content,width=30, text='Move Files', command= lambda: self.getMoveFolder()).grid(row=2, column=0, padx=10, pady=20)
    
        check_move_file.makedb()

        ttk.Label(self.frame_content, text="Source Folder").grid(row=0, column=1, padx=10, pady=3)
        self.src_var = StringVar()
        self.entry_src = ttk.Entry(self.frame_content, width=60, textvariable=self.src_var)
        self.entry_src.grid(row=0, column=2, padx=10, pady=3)
        self.entry_src.configure(state='readonly')
        
        ttk.Label(self.frame_content, text="Destination Folder").grid(row=1, column=1, padx=10, pady=3)
        self.dst_var = StringVar()
        self.entry_dst = ttk.Entry(self.frame_content, width=60, textvariable=self.dst_var)
        self.entry_dst.grid(row=1, column=2, padx=10, pady=3)
        self.entry_dst.configure(state='readonly')

        ttk.Label(self.frame_content, text="Last File Check").grid(row=2, column=1, padx=10, pady=3)
        self.last_change = StringVar()
        self.last_change.set(check_move_file.fwd_tmstmp())
        self.entry_dst = ttk.Entry(self.frame_content, width=60, textvariable=self.last_change)
        self.entry_dst.grid(row=2, column=2, padx=10, pady=3)
        self.entry_dst.configure(state='readonly')

    def getMoveFolder(self):
         check_move_file.moveModFiles(self.src_var.get(),self.dst_var.get())
         self.last_change.set(check_move_file.fwd_tmstmp())

    def getSourceFolder(self):
        src_dirname = filedialog.askdirectory()
        self.src_var.set(src_dirname+'/')

    def getDestFolder(self):
        dst_dirname = filedialog.askdirectory()
        self.dst_var.set(dst_dirname+'/')




        
 
def main():
    root = Tk()
    dailymover = DailyMover(root)
    root.mainloop()

if __name__ == "__main__": main()
