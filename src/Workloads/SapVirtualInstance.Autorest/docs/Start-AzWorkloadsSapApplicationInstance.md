---
external help file:
Module Name: Az.Workloads
online version: https://learn.microsoft.com/powershell/module/az.workloads/start-azworkloadssapapplicationinstance
schema: 2.0.0
---

# Start-AzWorkloadsSapApplicationInstance

## SYNOPSIS
Starts the SAP Application Server Instance.

## SYNTAX

### StartExpanded (Default)
```
Start-AzWorkloadsSapApplicationInstance -Name <String> -ResourceGroupName <String>
 -SapVirtualInstanceName <String> [-SubscriptionId <String>] [-StartVM] [-DefaultProfile <PSObject>] [-AsJob]
 [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Start
```
Start-AzWorkloadsSapApplicationInstance -Name <String> -ResourceGroupName <String>
 -SapVirtualInstanceName <String> -Body <IStartRequest> [-SubscriptionId <String>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### StartViaIdentity
```
Start-AzWorkloadsSapApplicationInstance -InputObject <ISapVirtualInstanceIdentity> -Body <IStartRequest>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### StartViaIdentityExpanded
```
Start-AzWorkloadsSapApplicationInstance -InputObject <ISapVirtualInstanceIdentity> [-StartVM]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Starts the SAP Application Server Instance.

## EXAMPLES

### Example 1: Start Application server instance of the SAP system
```powershell
Start-AzWorkloadsSapApplicationInstance -Name app0 -ResourceGroupName db0-vis-rg -SapVirtualInstanceName DB0
```

```output
AdditionalInfo    :
Code              :
Detail            :
EndTime           : 15-03-2023 08:21:31
Id                : /subscriptions/49d64d54-e966-4c46-a868-1999802b762c/providers/Microsoft.Workloads/locations/CENTRALUSEUAP/operationStatuses/58527855-a695-48a5-ac11-fbc
                    74b836859*DF20ACAC495F17B1D0D9182C3A4C44BC6EDFF718387348FAE17F19BCB5DE687C
Message           :
Name              : 58527855-a695-48a5-ac11-fbc74b836859*DF20ACAC495F17B1D0D9182C3A4C44BC6EDFF718387348FAE17F19BCB5DE687C
Operation         :
PercentComplete   :
ResourceGroupName :
StartTime         : 15-03-2023 08:18:22
Status            : Succeeded
Target            :
```

Start-AzWorkloadsSapApplicationInstance cmdlet starts the App server instance of the SAP system represented by the VIS.
Currently, start action is supported for ABAP stack.
In this example, you can see that instance can be started by passing the App server instance resource name, Resource Group name and VIS name as inputs.

### Example 2: Start Application server instance of the SAP system
```powershell
Start-AzWorkloadsSapApplicationInstance -InputObject /subscriptions/49d64d54-e966-4c46-a868-1999802b762c/resourceGroups/db0-vis-rg/providers/Microsoft.Workloads/sapVirtualInstances/DB0/applicationInstances/app0
```

```output
AdditionalInfo    :
Code              :
Detail            :
EndTime           : 15-03-2023 09:11:00
Id                : /subscriptions/49d64d54-e966-4c46-a868-1999802b762c/providers/Microsoft.Workloads/locations/CENTRALUSEUAP/operationStatuses/651c6f1b-db7
                    b-46b2-ba9a-fb5ee67ec372*D9A8F8EF15D6E75CE64E8F442A39F1D7AF307793D262CE855530D335419055E3
Message           :
Name              : 651c6f1b-db7b-46b2-ba9a-fb5ee67ec372*D9A8F8EF15D6E75CE64E8F442A39F1D7AF307793D262CE855530D335419055E3
Operation         :
PercentComplete   :
ResourceGroupName :
StartTime         : 15-03-2023 09:08:45
Status            : Succeeded
Target            :
```

Start-AzWorkloadsSapApplicationInstance cmdlet starts the App server instance of the SAP system represented by the VIS.
Currently, start action is supported for ABAP stack.
In this example, you can see that instance can be started by passing the App server instance Azure resource ID as InputObject to the cmdlet.

### Example 3: Start Application server instance of the SAP system and its underlying Virtual Machine
```powershell
Start-AzWorkloadsSapApplicationInstance -Name app0 -ResourceGroupName db0-vis-rg -SapVirtualInstanceName DB0 -StartVM
```

```output
AdditionalInfo    :
Code              :
Detail            :
EndTime           : 15-03-2023 08:21:31
Id                : /subscriptions/49d64d54-e966-4c46-a868-1999802b762c/providers/Microsoft.Workloads/locations/CENTRALUSEUAP/operationStatuses/58527855-a695-48a5-ac11-fbc
                    74b836859*DF20ACAC495F17B1D0D9182C3A4C44BC6EDFF718387348FAE17F19BCB5DE687C
Message           :
Name              : 58527855-a695-48a5-ac11-fbc74b836859*DF20ACAC495F17B1D0D9182C3A4C44BC6EDFF718387348FAE17F19BCB5DE687C
Operation         :
PercentComplete   :
ResourceGroupName :
StartTime         : 15-03-2023 08:18:22
Status            : Succeeded
Target            :
```

Start-AzWorkloadsSapApplicationInstance cmdlet starts the App server instance of the SAP system and its underlying Virtual Machines represented by the VIS.
Currently, start action is supported for ABAP stack.
In this example, you can see that the VMs and instance can be started by passing the App server instance resource name, Resource Group name, VIS name and StartVM parameter as inputs.

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Start SAP instance(s) request body.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IStartRequest
Parameter Sets: Start, StartViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.ISapVirtualInstanceIdentity
Parameter Sets: StartViaIdentity, StartViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of SAP Application Server instance resource.

```yaml
Type: System.String
Parameter Sets: Start, StartExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: Start, StartExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SapVirtualInstanceName
The name of the Virtual Instances for SAP solutions resource

```yaml
Type: System.String
Parameter Sets: Start, StartExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartVM
The boolean value indicates whether to start the virtual machines before starting the SAP instances.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: StartExpanded, StartViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.
The value must be an UUID.

```yaml
Type: System.String
Parameter Sets: Start, StartExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IStartRequest

### Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.ISapVirtualInstanceIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api50.IOperationStatusResult

## NOTES

ALIASES

Start-AzVISApplicationInstance

## RELATED LINKS
