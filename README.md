[![Build and deploy dotnet core app to Azure Function App - cds-services](https://github.com/microsoft/cds-services/actions/workflows/continuous-integration.yml/badge.svg)](https://github.com/microsoft/cds-services/actions/workflows/continuous-integration.yml)

# CDS Hook Services - Starter kit
Learn more about CDS Hooks at [https://cds-hooks.org](https://cds-hooks.org)

Services in this kit include:
- [patient-view-sample](src/Api/PatientViewSample.cs) - A patient-view hook service which requests the patient record as prefetch data and returns a sample card with the patient's name.
- order-sign - Will use CDC guidelines to determine if patient is over the recommended Morphine milligram equivalent (MME) dosage.
- patient-view/order-sign - treatment plan guidance

## Getting Started
1. [Fork](https://github.com/microsoft/cds-services/fork) this repo, then clone to your machine.
1. Open `src/CDSServices.sln` with Visual Studio or VSCode.
1. Start debugging with "F5"
1. Grab the full URL of the `/api/cds-services` discovery endpoint. (This will be displayed in your terminal window after the project starts)
1. Browse to [https://launch.smarthealthit.org](https://launch.smarthealthit.org) SMART launch simulator.
1. Select "CDS Hook Services". Next, select a sample patient. Finally, paste the HttpServiceDiscovery URL and click "Launch". Click "Login" on the sample practitioner login screen.
![SMART launch sandbox](./docs/imgs/smartlaunch.png)
1. Once the CDS Hook sandbox loads, select the "patient-view-sample" service from the dropdown in order to inspect the request/response data.
![CDS Hook Sandbox](./docs/imgs/cds_sandbox.png)

## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.opensource.microsoft.com.

When you submit a pull request, a CLA bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Trademarks

This project may contain trademarks or logos for projects, products, or services. Authorized use of Microsoft 
trademarks or logos is subject to and must follow 
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
Use of Microsoft trademarks or logos in modified versions of this project must not cause confusion or imply Microsoft sponsorship.
Any use of third-party trademarks or logos are subject to those third-party's policies.
