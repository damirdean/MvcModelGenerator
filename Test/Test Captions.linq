<Query Kind="Statements">
  <Reference Relative="..\..\..\Rhetos\Source\Rhetos\bin\Generated\Captions.dll">C:\My Projects\Rhetos\Source\Rhetos\bin\Generated\Captions.dll</Reference>
  <Namespace>System.Globalization</Namespace>
</Query>

//var assembly = typeof(Rhetos.Mvc.Captions).Assembly;
//new
//{
//	assembly.Location,
//	ManifestResourceNames = assembly.GetManifestResourceNames()
//}.Dump();

if (Rhetos.Mvc.Captions.Bookstore_Book.Dump("Captions.Bookstore_Book") != "Book")
	throw new ApplicationException("Unexpected result.");
"Passed.".Dump();
