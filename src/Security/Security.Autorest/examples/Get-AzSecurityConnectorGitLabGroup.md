### Example 1: Get discovered GitLab group by name
```powershell
Get-AzSecurityConnectorGitLabGroup -ResourceGroupName dfdtest-sdk -SecurityConnectorName dfdsdktests-gl-01 -GroupFqName dfdsdktests
```

```output
FullyQualifiedFriendlyName      : Defender for DevOps SDK Tests
FullyQualifiedName              : dfdsdktests
Id                              : /subscriptions/487bb485-b5b0-471e-9c0d-10717612f869/resourceGroups/dfdtest-sdk/providers/Microsoft.Security/securityConnectors/dfdsdktests-gl-01/devops/default/gitLabGroups/dfdsdktests
Name                            : dfdsdktests
OnboardingState                 : Onboarded
ProvisioningState               : Succeeded
ProvisioningStatusMessage       : Resource modification successful.
ProvisioningStatusUpdateTimeUtc : 2/23/2024 10:42:28 PM
ResourceGroupName               : dfdtest-sdk
SystemDataCreatedAt             : 
SystemDataCreatedBy             : 
SystemDataCreatedByType         : 
SystemDataLastModifiedAt        : 
SystemDataLastModifiedBy        : 
SystemDataLastModifiedByType    : 
Type                            : Microsoft.Security/securityConnectors/devops/gitLabGroups
Url                             : https://gitlab.com/groups/dfdsdktests
```

### Example 2: List discovered GitLab groups
```powershell
Get-AzSecurityConnectorGitLabGroup -ResourceGroupName dfdtest-sdk -SecurityConnectorName dfdsdktests-gl-01
```

```output
Name              ResourceGroupName
----              -----------------
dfdsdktests       dfdtest-sdk
dfdsdktests2      dfdtest-sdk
```



