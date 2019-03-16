# UnitedWayCommunityResources
Project for CSCI 340

The purpose of this project was to redesign the United Way of Central Arkansas' [Community Resources Page](https://www.uwcark.org/help), which was difficult to navigate, understand, and update. We used the ASP.net framework to create an easily navigatible oommunity resources with a backend database. We have screenshots of various aspects of the website below:

Our main screen for the United Way Community Resources Page has 12 categories of services offered. The pictures are intended to help people who may not be able to read English well navigate the webiste. There is also a translation option for Spanish and Mandrian. 

![MainScreen](https://github.com/baertt/UnitedWayCommunityResources/blob/master/ScreenShots/screencapture-localhost-53661-2018-07-08-21_23_58.png)
![MainScreenSpanish](https://github.com/baertt/UnitedWayCommunityResources/blob/master/ScreenShots/screencapture-localhost-53661-2018-07-08-21_31_38.png)

Once a user clicks on a type of resource, they can filter the organizations that offer that resource by date, day of the week, and/or time. This is an important feature because some orgainzations are just open twice a month at different times. 

![ResultsScreen](https://github.com/baertt/UnitedWayCommunityResources/blob/master/ScreenShots/screencapture-localhost-53661-Home-InitialResults-2-2018-07-08-21_25_48.png)

We also wanted to make this site easily manageable by the United Way staff. Our main admin page is automatically filtered by date last updated, but the admin can also find specific orgainzations by name.

![AdminResults](https://github.com/baertt/UnitedWayCommunityResources/blob/master/ScreenShots/screencapture-localhost-53661-Organizations-2018-07-08-21_26_50.png)

When an admin wants to create a new resource, they are directed to a series of pages for filling out orgainzation information. The first page asks for the name and service requirements. The second page asks for types of resources offered. The final page allows the admin to add in times that the organization is open. The data structure was designed to hold information such as "open the 3rd Thursday of the Month from 9:00-11:00 AM and 1:00-5:00 PM". All of this information can be updated by the admin at a later date as well. 

![NewResourceName](https://github.com/baertt/UnitedWayCommunityResources/blob/master/ScreenShots/screencapture-localhost-53661-Organizations-Create-2018-07-08-21_27_42.png)
![NewResourceResources](https://github.com/baertt/UnitedWayCommunityResources/blob/master/ScreenShots/screencapture-localhost-53661-Resources-Create-116-2018-07-08-21_29_09.png)
![NewResourceTimeScreen](https://github.com/baertt/UnitedWayCommunityResources/blob/master/ScreenShots/screencapture-localhost-53661-Times-AddTimes-116-2018-07-08-21_30_40.png)
![NewResourceTimeAdding](https://github.com/baertt/UnitedWayCommunityResources/blob/master/ScreenShots/screencapture-localhost-53661-Times-Create-116-2018-07-08-21_31_16.png)


