### Example 1: Update an AzureFrontDoor security policy within the specified AzureFrontDoor profile
```powershell
$endpoint = Get-AzFrontDoorCdnEndpoint -ResourceGroupName testps-rg-da16jm -ProfileName fdp-v542q6 -EndpointName end001
$endpoint2 = Get-AzFrontDoorCdnEndpoint -ResourceGroupName testps-rg-da16jm -ProfileName fdp-v542q6 -EndpointName end002
$updateAssociation = New-AzFrontDoorCdnSecurityPolicyWebApplicationFirewallAssociationObject -PatternsToMatch @("/*") -Domain @(@{"Id"=$($endpoint.Id)})
$updateAssociation2 = New-AzFrontDoorCdnSecurityPolicyWebApplicationFirewallAssociationObject -PatternsToMatch @("/*") -Domain @(@{"Id"=$($endpoint2.Id)})            

$wafPolicyId = "/subscriptions/xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx/resourcegroups/rgName01/providers/Microsoft.Network/frontdoorwebapplicationfirewallpolicies/waf01"
$updateWafParameter = New-AzFrontDoorCdnSecurityPolicyWebApplicationFirewallParametersObject  -Association @($updateAssociation, $updateAssociation2) -WafPolicyId $wafPolicyId
Update-AzFrontDoorCdnSecurityPolicy -ResourceGroupName testps-rg-da16jm -ProfileName fdp-v542q6 -Name policy001 -Parameter $updateWafParameter
```

```output
Name      ResourceGroupName
----      -----------------
policy001 testps-rg-da16jm
```

Update an AzureFrontDoor security policy within the specified AzureFrontDoor profile


### Example 2: Update an AzureFrontDoor security policy within the specified AzureFrontDoor profile via identity
```powershell
$endpoint = Get-AzFrontDoorCdnEndpoint -ResourceGroupName testps-rg-da16jm -ProfileName fdp-v542q6 -EndpointName end001
$endpoint2 = Get-AzFrontDoorCdnEndpoint -ResourceGroupName testps-rg-da16jm -ProfileName fdp-v542q6 -EndpointName end002
$updateAssociation = New-AzFrontDoorCdnSecurityPolicyWebApplicationFirewallAssociationObject -PatternsToMatch @("/*") -Domain @(@{"Id"=$($endpoint.Id)})
$updateAssociation2 = New-AzFrontDoorCdnSecurityPolicyWebApplicationFirewallAssociationObject -PatternsToMatch @("/*") -Domain @(@{"Id"=$($endpoint2.Id)})            
                
$wafPolicyId = "/subscriptions/xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx/resourcegroups/rgName01/providers/Microsoft.Network/frontdoorwebapplicationfirewallpolicies/waf01"
$updateWafParameter = New-AzFrontDoorCdnSecurityPolicyWebApplicationFirewallParametersObject  -Association @($updateAssociation, $updateAssociation2) -WafPolicyId $wafPolicyId

Get-AzFrontDoorCdnSecurityPolicy -ResourceGroupName testps-rg-da16jm -ProfileName fdp-v542q6 -Name policy001 | Update-AzFrontDoorCdnSecurityPolicy -Parameter $updateWafParameter
```

Update an AzureFrontDoor security policy within the specified AzureFrontDoor profile via identity

