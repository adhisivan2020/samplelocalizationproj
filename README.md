# samplelocalizationproj
sample C# based localization project



Automation Approach

- Pass language setting as environment variable to the automation program
- Loadup Resource Manager (from .resx file) - If possible reuse the one developer is using
- Identify the GUI elements and read the values
- Using the element ID as key, read values from the Resource Manager based on Localization settings
- Match the values to confirm the UI elements in the workflow
