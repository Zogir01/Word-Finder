#it is used for sending data from python to c#
from win32 import win32file, win32pipe

class PipeClient:
    pipe_handle = None
    pipe_name = None

    def __init__(self, name):
        self.pipe_name = name
        self.pipe_handle = win32pipe.CreateNamedPipe(
                r'\\.\pipe\\'+name,
                win32pipe.PIPE_ACCESS_DUPLEX,
                win32pipe.PIPE_TYPE_MESSAGE | win32pipe.PIPE_READMODE_MESSAGE | win32pipe.PIPE_WAIT,
                1, 65536, 65536,
                0,
                None)

    def connect(self):
        win32pipe.ConnectNamedPipe(self.pipe_handle, None)
    
    def disconnect(self):
        win32pipe.DisconnectNamedPipe(self.pipe_handle)
        win32file.CloseHandle(self.pipe_handle)
    
    def write(self, var):
        ret, length = win32file.WriteFile(self.pipe_handle, (var + '\n').encode())
        win32file.FlushFileBuffers(self.pipe_handle)