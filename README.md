## Give A Shit Backend

#To deploy

dotnet publish -o site

cd site
zip ../site.zip *
cd ..
zip GiveAShitBackend.zip site.zip aws-windows-deployment-manifest.json

Use aws panel to deploy the new GiveAShitBackend.zip