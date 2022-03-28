# PiiString

> Personally identifiable information (PII) is any information relating to an identified or identifiable natural person; an identifiable natural person is one who can be identified, directly or indirectly, in particular by reference to an identifier such as a name, an identification number, location data, an online identifier or to one or more factors specific to the physical, physiological, genetic, mental, economic, cultural or social identity of that natural person — [EU GDPR](https://www.privacy-regulation.eu/en/article-4-definitions-GDPR.htm).

The idea is to have `PiiString` type as much interchangeable with `String` as possible to simplify refactoring existing code which uses the `String`. Then, within the application boundary it should behave like usual `String`, however crossing application boundaries it should be encoded/encrypted/hashed.

Read [blogpost](https://gaevoy.com/2022/03/18/personally-identifiable-information-data-types.html) for more details.

### NuGet packages

* [PiiTypes](https://www.nuget.org/packages/PiiTypes/)
* [PiiTypes.NewtonsoftJson](https://www.nuget.org/packages/PiiTypes.NewtonsoftJson/)
* [PiiTypes.SystemTextJson](https://www.nuget.org/packages/PiiTypes.SystemTextJson/)
* [PiiTypes.EFCore3](https://www.nuget.org/packages/PiiTypes.EFCore3/)
