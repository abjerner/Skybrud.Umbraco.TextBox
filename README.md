# Skybrud.Umbraco.TextBox

**Skybrud.Umbraco.TextBox** is a package that adds new textbox and textarea properties for Umbraco 9. While having similar functionality to the build in property editors, this package adds a few extra features:

- **More visible character limit**  
  The default property editors in Umbraco only shows the limit when it has been reached, whereas the property editors in this package show the limit right away, kaing it more visual to the editor that there is a limit.
  
- **Enforced character limit**  
  Umbraco will only show the limit when it has been reached or exceeded, but not actually enforce the character limit. Via the config option on the data type, the property editors in this package can be configured to prevent the user from exceeding the character limit.
  
- **Placeholder text**  
  Both the textbox and textarea property editors allows setting a placeholder text that will be visible to the user when editing the properties in the backoffice.

- **Fallback text**  
  An optional fallback text may be set on the data type to be used instead when the property is left blank. The underlying property value converter will make sure the fallback value is returned when this is the case.

## Installation

The Umbraco 9 version of this package is only available via NuGet. To install the package, you can use either .NET CLI:

```
dotnet add package Skybrud.Umbraco.TextBox --version 2.0.0
```


or the older NuGet Package Manager:

```
Install-Package Skybrud.Umbraco.TextBox -Version 2.0.0
```

For Umbraco 8, see the [**v1/main** branch](https://github.com/abjerner/Skybrud.Umbraco.TextBox/tree/v1/main#installation).

[NuGetPackage]: https://www.nuget.org/packages/Skybrud.Umbraco.TextBox
[GitHubRelease]: https://github.com/abjerner/Skybrud.Umbraco.TextBox/releases

## Screenshots

*Empty properties with the placeholder text visible*
![image](https://user-images.githubusercontent.com/3634580/88987152-5db17780-d2d5-11ea-889b-ebcad9ca80ba.png)

*Properties with values below the character limit*
![image](https://user-images.githubusercontent.com/3634580/88987187-73bf3800-d2d5-11ea-8962-b6395da8dd87.png)

*Properties with values above the character limit, but not enforced*
![image](https://user-images.githubusercontent.com/3634580/88988260-a9195500-d2d8-11ea-97ac-748dd8748832.png)

*The configuration options (prevalues) of the textarea data type*
![image](https://user-images.githubusercontent.com/3634580/88987630-db29b780-d2d6-11ea-86ea-77885086f3b7.png)
