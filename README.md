# Darkest Dungeon Companion App

For my UWP project I have chosen to make a companion app to the game "Darkest Dungeon" which is avalible on nearly every device possible even windows phone. The following document will outline the mechanics of the game and how the app correlates to them. 

## A Bit About The Game Itself

Before I go into the details of how the app works and what features it has I think it would be best to outline some brief mechanics of the game first as they are crucial in understanding how the app works. Darkest Dungeon (or, DD for short) is a game about making the best of a bad situation. The player is incontrol of a small hamlet on the bring of destruction and the player must guide various teams of "Heroes" throughout 5 unique areas. The purpose of bringing heroes out on expeditions to these areas is mainly for loot which can be used to upgrade your hamlet but also to try and stop the forces of cosmic horror from descending upon your hamlet. DD is by NO means at all an easy game. Often called by many as one of the hardest games of all time a guide or walkthough close at hand is almost needed if you wish to prevail. Thats where the idea for my app came from, a close at hand app that can give you the right info you need for each area. The app displays the 5 key areas of the game and clicking into them will show you tips on how to best survive the area as well as an "Expedition Guide" which shows you what items to take to each area (Example: the warrens are filled with disease ridden swine folk who like to use poison moves, so bringing lots of "anti-venom" to that area will help the player greately). On top of this, each area has a different "adventure length" (short, medium and long) which also require different items depending on each different adventure length. I incorporated this into my expedition guide table. One of DD's greatest features is its sound design which I also incorporated into my app, throughout the game you are haunted by narration of your ghostly ancestor so I though it was only fitting to add his dialogue lines to the app itself. Another big feature is the profit calculator. After each adventure you are shown how much loot you have brought back (which is automatically sold) but the game DOES not actually tell you how much the loot is worth, its a case of "Huh, my total money just went up a good bit but I'm not sure why), So, I added the feature for users to see how much total loot they obtained by adding them up with the apps calculator, calculator is simple to use as each loot option corresponds to a certain button and adds them all to a total.  

### Design Steps

This project took over 2 months to do and these steps outline the process I took to complete it. On top of having to actually make the app itself I also had to have it submitted to the windows store, which I also achieved 

```
1.) To start off I orginally tried implementing pivots into my app (hence why its called pivot test 1).
2.) Once pivots were implemented I created two seperate ones, one for expedition guides and one for the profit calculator. 
3.) Added buttons that corisponded to each area in the game, at the time they were just simple blank buttons with 
text for each area.
4.) Added the ability for each button to take you to a different page 
5.) Added a back button feature, by pressing the button the user would be redirected to the main page. 
4.) Before adding any details to any of the areas, I decdied it would be best to work on the calculator function first.
5.) Before I actually tried using the calculator myself I looked to the microsoft docs to find a test version of one
once found I set to work on seeing how I could implement it to my design 
6.) The one I found via the docs was more complex than I expected as it dealt with tress which is something i've never tried 
before with a coding language so for the time I decided to just leave it as it is and worry about it another day. 
7.) I decided to work on the expedition guide for each area as well as the area length. 
8.) To do this I desigined my own table using lines, textboxes and images from the game itself. This took me a lot of time and patience
as the guide lines would constantly mess up and things would look out of place. 
9.) With the table done for one area, I copied and pasted it to the other pages (no values were outputted into the table at this point)
10.) next up I outputted the reccomended item values to each area and each area length, table showed a little bit of resistence, but I was able to work around it quite well. 
11.) I decided to finally learn the calculator provided by docs and understand it, this took a bit of getting used to as I had no experience with trees before. 
12.) After doing some study online (and some testing via taking out lines and adding them back in) I was fimilar with what I was working with and was able to implement my own calculator idea into it. 
13.) After the calculator was done I added design to it as well as item pictures that correspond to each different loot amount. 
14.) With the main bulk of the app completed I needed to add some more stuff to it, since one of DD's greatest achievments is its haunting sound track accompnied by annoucer like lines from your falled ancestor I saw it fitting to add a qutoe from the man himself that corresponds to each area in the game. This was achieved rather easily. 
15.) After adding sound to each area I then added tips for each area, what you should look out for as well as what team of 4 heroes would be best suited for the area. 
```

Next onto the hard part, submission to the windows store. This isnt as hard as I made it out to be but due to some....complications I found it more difficult then it had to be. Thanks to help from the author of this link: https://jeremylindsayni.wordpress.com/2016/04/13/how-to-submit-a-uwp-app-to-the-windows-store/

Without it I would of got no where. 

```
1.) The first step required was that I needed to register as dev for microsoft, the process took about 20 mins-30mins for sign up and about 8 hours for my account to be offcially verified. My college provided keys that allowed people to access dev accounts for free but for some strange reason the system was telling me my key was already verified (It wasn't, the day I recieved the key was also apperently the day I used it, which did not make sense). After NUMEROUS attempts to contact microsoft and find out the problem I was left with vague emails telling me to contact other people who would then in turn tell me to contact the original person who sent me to them. Figuring I was wasting valuable time I decided to just man up and pay the 19 euro asked. 
2.) The next step was to register the name of my app
```

### Installing

A step by step series of examples that tell you have to get a development env running

Say what the step will be

```
Give the example
```

And repeat

```
until finished
```

End with an example of getting some data out of the system or using it for a little demo

## Running the tests

Explain how to run the automated tests for this system

### Break down into end to end tests

Explain what these tests test and why

```
Give an example
```

### And coding style tests

Explain what these tests test and why

```
Give an example
```

## Deployment

Add additional notes about how to deploy this on a live system

## Built With

* [Dropwizard](http://www.dropwizard.io/1.0.2/docs/) - The web framework used
* [Maven](https://maven.apache.org/) - Dependency Management
* [ROME](https://rometools.github.io/rome/) - Used to generate RSS Feeds

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Billie Thompson** - *Initial work* - [PurpleBooth](https://github.com/PurpleBooth)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Hat tip to anyone who's code was used
* Inspiration
* etc

