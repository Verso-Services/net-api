# net-api
.NET Library for connecting with Verso

The c# API client example was developed using the Visual Studio 2013. In order to test the project you will need to:

1- Download and install Visual Studio 2013, here are some links that could be useful:
- https://www.visualstudio.com/en-us/downloads/download-visual-studio-vs.aspx Visual Studio download link
 - https://msdn.microsoft.com/en-us/library/e2h7fzkw.aspx Visual Studio installation instructions.
2- Download the API client code from the following GitHub repository: Here we have two options:
 - Download as .zip directly with the following link: https://github.com/Verso-Services/net-api/archive/master.zip .
 - Or Download it from https://github.com/Verso-Services/net-api using git bash
3- Open the downloaded project on Visual Studio:
- Under the VersoClient.cs file you will be able to see how to connect to Verso API in the ImportArticlesBatch method.
- We need to specify the Verso API Url to be used.
- The ImportArticlesBatchInfo object is the one to be be serialize to json object and be sent to the Verso API, this class handles three different properties: UserName, Password and Articles.
- The first param refers to the Verso UserName to be authenticated while the second param refers to the user Password in the Verso system. Both UserName and Password have to match so that the Verso API can import the articles list.
- The property Articles of the ImportArticlesBatchInfo class is where you add the articles to be imported. For this, we created a class called ArticleInfo, this class is in charge of handling every single article object property.
- Add the ArticleInfo objects that we need to import to the Verso API.
- Finally we prepare the http client request and do what we need with the response.

Note: For this example we use two external references: Newtonsoft.Json and System.Net.Http. You can find this references  in the packages of source code downloaded from GitHub. For more information about this libraries refer to:
 - https://msdn.microsoft.com/en-us/library/system.net.http(v=vs.118).aspx 
 - http://www.newtonsoft.com/json 
