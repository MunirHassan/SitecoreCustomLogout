# Sitecore Custom Logout
Simple way to Logout from Sitecore and send user to a custom Logout landing page.

## Facts:
Usually when a user logged out from Sitecore, he/she send to the Sitecore Login page. But a scenario arise that we need to send user to a custom page.
How could we do that?

Simple way is to create a Processor and patch/inject the processor in the Sitecore Logout pipeline, that processor will send you to the custom Logout page.
Interestingly Sitecore has two different pipelines for Logout. If you Logout from Sitecore Desktop and if you Logout from Launchpad, they are executing in different pipelines.
One is the general Logout pipeline and other one is SPEAK Logout pipeline.

## Solution:
I have created a processor where referencing Sitecore.Kernel dll.
I have also created couple of Config files, which need to be present in the Website->App_Config -> include directory.
And finally "Sitecore.Custom.Logout.dll" needs to be copied to the Website->bin directory.

Now Logout and see the Magic.
