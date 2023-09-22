import winim

const MAX_PIDLIST: int = 1024
const MAX_PNAME: int = 255

proc getProcessIDs(lpidProcess: var array[MAX_PIDLIST, int32]): int {.cdecl, exportc, dynlib.} = 
    var
        cb: int32 = cast[int32](sizeof(lpidProcess))
        lpcbNeeded: int32

    if EnumProcesses(addr lpidProcess[0], cb, addr lpcbNeeded) == 0:
        return 0

    return 1 

proc getProcessName(pid: DWORD, sProcessName: var array[MAX_PNAME, char]): int {.cdecl, exportc, dynlib.} = 
    var
        dwDesiredAccess: DWORD = PROCESS_QUERY_INFORMATION or PROCESS_VM_READ
        bInheritHandle: BOOL = false
        dwProcessId: DWORD = pid
        hProcess: HANDLE

    hProcess = OpenProcess(dwDesiredAccess, bInheritHandle, dwProcessId)

    if not cast[bool](hProcess):
        return 0

    var 
        hMod: HMODULE
        cb: DWORD = cast[DWORD](sizeof(hMod))
        lpcNeeded: DWORD
    
    if EnumProcessModules(hProcess, &hMod, cb, &lpcNeeded) == 0:
        return 0

    if GetModuleBaseNameA(hProcess, hMod, addr sProcessName[0], cast[DWORD](sProcessName.len)) < 1:
       return 0

    CloseHandle(hProcess)
    return 1