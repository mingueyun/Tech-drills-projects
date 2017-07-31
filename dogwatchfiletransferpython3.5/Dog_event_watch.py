import time
from watchdog.observers import Observer
from watchdog.events import FileSystemEventHandler

##import Daily_file_transfer
import os
import psutil
pid = os.getpid()
py = psutil.Process(pid)
memoryUse = py.memory_info()[0]/2.**30  # memory use in GB...I think
print('memory use:', memoryUse)

class Watcher:
    DIRECTORY_TO_WATCH = 'C:\\Users\\Min Kyu\\Desktop\\A'

    def __init__(self):
        self.observer = Observer()

    def run(self):
        event_handler = Handler()
        self.observer.schedule(event_handler, self.DIRECTORY_TO_WATCH, recursive=True)
        self.observer.start()
        try:
            while True:
                print("This prints every 10 secs once it executes a thread.")
                time.sleep(10)
         #add exceptkeyboardinterupt       
        except:
            self.observer.stop()
            print ("Error")

        self.observer.join()


class Handler(FileSystemEventHandler):
# staticmethod states its a insance of class watcher
    @staticmethod
    def on_any_event(event):
        if event.is_directory:
            return None

        elif event.event_type == 'created':
            # Take any action here when a file is first created.
            print ("Received created event at.", event.src_path)

        elif event.event_type == 'modified':
            # Taken any action here when a file is modified.
##            last_mod_time(dst)
            print('memory use:', memoryUse)
            print ("Received modified event at.", event.src_path)
            

if __name__ == '__main__':
    w = Watcher()
    w.run()
    w.mainloop()
