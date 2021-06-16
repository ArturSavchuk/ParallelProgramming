#  MY DOCUMENTATION #
##  <a id="namespace-list" />  Namespaces ##

 | Name | Summary | 
 | ------ | --------- | 
 | [Lab2](#n-lab2__1mm6f8h) |  | 

##  <a id="type-list" />  Types ##

 | Name | Modifier | Kind | Summary | 
 | ------ | ---------- | ------ | --------- | 
 | [CPU](#t-lab2.cpu__n9yn7) | internal | Class |  | 
 | [CPUProcess](#t-lab2.cpuprocess__1hv7j4w) | internal | Class |  | 
 | [CPUQueue](#t-lab2.cpuqueue__8kiswi) | internal | Class |  | 

Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="n-lab2__1mm6f8h" />  Lab2 Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CPU](#t-lab2.cpu__n9yn7) | internal |  | 
 | [CPUProcess](#t-lab2.cpuprocess__1hv7j4w) | internal |  | 
 | [CPUQueue](#t-lab2.cpuqueue__8kiswi) | internal |  | 

 


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="t-lab2.cpu__n9yn7" />  CPU Class ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Sources: CPU.cs</small>



```csharp
internal class CPU
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [busy](#f-lab2.cpu.busy__1qu9uso) | private |  | 
 | [counter](#f-lab2.cpu.counter__1r0gv9n) | private static |  | 
 | [interrupted_count](#f-lab2.cpu.interrupted_count__c05jih) | public static |  | 
 | [max](#f-lab2.cpu.max__i7pl3) | private |  | 
 | [min](#f-lab2.cpu.min__1aexooh) | private |  | 
 | [process](#f-lab2.cpu.process__1gntfum) | public |  | 
 | [sw](#f-lab2.cpu.sw__10vvx93) | private |  | 
 | [syncLock](#f-lab2.cpu.synclock__1avtbrf) | private static |  | 
 | [time](#f-lab2.cpu.time__1w2b2rk) | private |  | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CPU(int, int)](#m-lab2.cpu.-ctor_system.int32-system.int32___1c44fdg) | public |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [getProcess()](#m-lab2.cpu.getprocess__wxxg5t) | public |  | 
 | [InterruptProcess()](#m-lab2.cpu.interruptprocess__1pzvcys) | public |  | 
 | [isBusy()](#m-lab2.cpu.isbusy__m5f5eb) | public |  | 
 | [Run()](#m-lab2.cpu.run__36yyu9) | public |  | 
 | [setProcess(CPUProcess)](#m-lab2.cpu.setprocess_lab2.cpuprocess___uf1vq8) | public |  | 
 | [setTask(CPUProcess)](#m-lab2.cpu.settask_lab2.cpuprocess___mlkp20) | public |  | 

 


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpu.busy__1qu9uso" />  CPU.busy Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
private bool busy
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpu.counter__1r0gv9n" />  CPU.counter Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
private static int counter
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpu.interrupted_count__c05jih" />  CPU.interrupted_count Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
public static int interrupted_count
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpu.max__i7pl3" />  CPU.max Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
private int max
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpu.min__1aexooh" />  CPU.min Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
private int min
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpu.process__1gntfum" />  CPU.process Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
public CPUProcess process
```

<strong>Field value</strong><dl><dt>[Lab2.CPUProcess](#t-lab2.cpuprocess__1hv7j4w)</dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpu.sw__10vvx93" />  CPU.sw Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
private Stopwatch sw
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch" target="_blank" >System.Diagnostics.Stopwatch</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpu.synclock__1avtbrf" />  CPU.syncLock Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
private static readonly object syncLock
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpu.time__1w2b2rk" />  CPU.time Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
private int time
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpu.-ctor_system.int32-system.int32___1c44fdg" />  CPU.CPU(int, int) Constructor ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
public CPU(int min, int max)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>min</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>max</strong></dt><dd></dd></dl>
Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpu.getprocess__wxxg5t" />  CPU.getProcess() Method ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
public CPUProcess getProcess()
```

<strong>Return value</strong><dl><dt>[Lab2.CPUProcess](#t-lab2.cpuprocess__1hv7j4w)</dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpu.interruptprocess__1pzvcys" />  CPU.InterruptProcess() Method ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
public void InterruptProcess()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpu.isbusy__m5f5eb" />  CPU.isBusy() Method ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
public bool isBusy()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpu.run__36yyu9" />  CPU.Run() Method ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
public void Run()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpu.setprocess_lab2.cpuprocess___uf1vq8" />  CPU.setProcess(CPUProcess) Method ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
public void setProcess(CPUProcess process)
```

<strong>Method parameters</strong><dl><dt>[Lab2.CPUProcess](#t-lab2.cpuprocess__1hv7j4w) <strong>process</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpu.settask_lab2.cpuprocess___mlkp20" />  CPU.setTask(CPUProcess) Method ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPU](#t-lab2.cpu__n9yn7)           
Sources: CPU.cs</small>



```csharp
public void setTask(CPUProcess p)
```

<strong>Method parameters</strong><dl><dt>[Lab2.CPUProcess](#t-lab2.cpuprocess__1hv7j4w) <strong>p</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="t-lab2.cpuprocess__1hv7j4w" />  CPUProcess Class ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Sources: CPUProcess.cs</small>



```csharp
internal class CPUProcess
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [counter](#f-lab2.cpuprocess.counter__xfom1w) | public static |  | 
 | [flow](#f-lab2.cpuprocess.flow__5wv4fo) | public |  | 
 | [id](#f-lab2.cpuprocess.id__sh2nql) | public |  | 
 | [max](#f-lab2.cpuprocess.max__hu56aq) | private |  | 
 | [min](#f-lab2.cpuprocess.min__by1x78) | private |  | 
 | [time_slot](#f-lab2.cpuprocess.time_slot__1up8tz6) | public |  | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CPUProcess(int, int)](#m-lab2.cpuprocess.-ctor_system.int32-system.int32___13jow6j) | public |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SetID()](#m-lab2.cpuprocess.setid__fz5m8k) | public |  | 
 | [ToString()](#m-lab2.cpuprocess.tostring__1entrsp) | public |  | 

 


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpuprocess.counter__xfom1w" />  CPUProcess.counter Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUProcess](#t-lab2.cpuprocess__1hv7j4w)           
Sources: CPUProcess.cs</small>



```csharp
public static int counter
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpuprocess.flow__5wv4fo" />  CPUProcess.flow Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUProcess](#t-lab2.cpuprocess__1hv7j4w)           
Sources: CPUProcess.cs</small>



```csharp
public int flow
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpuprocess.id__sh2nql" />  CPUProcess.id Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUProcess](#t-lab2.cpuprocess__1hv7j4w)           
Sources: CPUProcess.cs</small>



```csharp
public int id
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpuprocess.max__hu56aq" />  CPUProcess.max Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUProcess](#t-lab2.cpuprocess__1hv7j4w)           
Sources: CPUProcess.cs</small>



```csharp
private int max
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpuprocess.min__by1x78" />  CPUProcess.min Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUProcess](#t-lab2.cpuprocess__1hv7j4w)           
Sources: CPUProcess.cs</small>



```csharp
private int min
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpuprocess.time_slot__1up8tz6" />  CPUProcess.time_slot Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUProcess](#t-lab2.cpuprocess__1hv7j4w)           
Sources: CPUProcess.cs</small>



```csharp
public int time_slot
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpuprocess.-ctor_system.int32-system.int32___13jow6j" />  CPUProcess.CPUProcess(int, int) Constructor ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUProcess](#t-lab2.cpuprocess__1hv7j4w)           
Sources: CPUProcess.cs</small>



```csharp
public CPUProcess(int time_slot, int flow)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>time_slot</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>flow</strong></dt><dd></dd></dl>
Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpuprocess.setid__fz5m8k" />  CPUProcess.SetID() Method ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUProcess](#t-lab2.cpuprocess__1hv7j4w)           
Sources: CPUProcess.cs</small>



```csharp
public void SetID()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpuprocess.tostring__1entrsp" />  CPUProcess.ToString() Method ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUProcess](#t-lab2.cpuprocess__1hv7j4w)           
Sources: CPUProcess.cs</small>



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Overrides: object.ToString


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="t-lab2.cpuqueue__8kiswi" />  CPUQueue Class ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Sources: CPUqueue.cs</small>



```csharp
internal class CPUQueue
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [id](#f-lab2.cpuqueue.id__1ab1am3) | public |  | 
 | [maxSize](#f-lab2.cpuqueue.maxsize__i0zsdj) | public |  | 
 | [queue](#f-lab2.cpuqueue.queue__mc3ygn) | private |  | 
 | [syncLock](#f-lab2.cpuqueue.synclock__wqdvj6) | private static |  | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CPUQueue(int)](#m-lab2.cpuqueue.-ctor_system.int32___1hgygfi) | public |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Dequeue()](#m-lab2.cpuqueue.dequeue__vws26p) | public |  | 
 | [InsertProcess(CPUProcess)](#m-lab2.cpuqueue.insertprocess_lab2.cpuprocess___1ugwd18) | public |  | 
 | [isEmpty()](#m-lab2.cpuqueue.isempty__1r2vtk2) | public |  | 
 | [showAllProcesses()](#m-lab2.cpuqueue.showallprocesses__1w6ggq8) | public |  | 
 | [toString()](#m-lab2.cpuqueue.tostring__71kcgn) | public |  | 

 


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpuqueue.id__1ab1am3" />  CPUQueue.id Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUQueue](#t-lab2.cpuqueue__8kiswi)           
Sources: CPUqueue.cs</small>



```csharp
public int id
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpuqueue.maxsize__i0zsdj" />  CPUQueue.maxSize Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUQueue](#t-lab2.cpuqueue__8kiswi)           
Sources: CPUqueue.cs</small>



```csharp
public int maxSize
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpuqueue.queue__mc3ygn" />  CPUQueue.queue Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUQueue](#t-lab2.cpuqueue__8kiswi)           
Sources: CPUqueue.cs</small>



```csharp
private Queue<Lab2.CPUProcess> queue
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1" target="_blank" >Queue&lt;Lab2.CPUProcess&gt;</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="f-lab2.cpuqueue.synclock__wqdvj6" />  CPUQueue.syncLock Field ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUQueue](#t-lab2.cpuqueue__8kiswi)           
Sources: CPUqueue.cs</small>



```csharp
private static readonly object syncLock
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpuqueue.-ctor_system.int32___1hgygfi" />  CPUQueue.CPUQueue(int) Constructor ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUQueue](#t-lab2.cpuqueue__8kiswi)           
Sources: CPUqueue.cs</small>



```csharp
public CPUQueue(int id)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>id</strong></dt><dd></dd></dl>
Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpuqueue.dequeue__vws26p" />  CPUQueue.Dequeue() Method ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUQueue](#t-lab2.cpuqueue__8kiswi)           
Sources: CPUqueue.cs</small>



```csharp
public CPUProcess Dequeue()
```

<strong>Return value</strong><dl><dt>[Lab2.CPUProcess](#t-lab2.cpuprocess__1hv7j4w)</dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpuqueue.insertprocess_lab2.cpuprocess___1ugwd18" />  CPUQueue.InsertProcess(CPUProcess) Method ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUQueue](#t-lab2.cpuqueue__8kiswi)           
Sources: CPUqueue.cs</small>



```csharp
public void InsertProcess(CPUProcess process)
```

<strong>Method parameters</strong><dl><dt>[Lab2.CPUProcess](#t-lab2.cpuprocess__1hv7j4w) <strong>process</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpuqueue.isempty__1r2vtk2" />  CPUQueue.isEmpty() Method ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUQueue](#t-lab2.cpuqueue__8kiswi)           
Sources: CPUqueue.cs</small>



```csharp
public bool isEmpty()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpuqueue.showallprocesses__1w6ggq8" />  CPUQueue.showAllProcesses() Method ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUQueue](#t-lab2.cpuqueue__8kiswi)           
Sources: CPUqueue.cs</small>



```csharp
public void showAllProcesses()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 


##  <a id="m-lab2.cpuqueue.tostring__71kcgn" />  CPUQueue.toString() Method ##
<small>Namespace: [Lab2](#n-lab2__1mm6f8h)           
Assembly: Lab2           
Type: [CPUQueue](#t-lab2.cpuqueue__8kiswi)           
Sources: CPUqueue.cs</small>



```csharp
public string toString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](doc.md#namespace-list) or [types](doc.md#type-list)


 



