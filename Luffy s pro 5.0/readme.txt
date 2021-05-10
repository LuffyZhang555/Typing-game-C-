The design of my project:
As my topic is the fourth topic, and it is about typing game. 
So there are something about the game:
1.	Blocks that will fail down as time goes by.
2.	Another block that will check if the input is correct with one of the blocks.
3.	Time.
4.	Health.
5.	Score.
6.	Also the list of every words.
These are the things that I think is basic of the game. Thus I put all these in my class ¡§game¡¨. And as we all know time, health, score, these properties are set at the beginning of the game, thus I use private and get to incase of changing from the outside. 
 Falling blocks:
I use the timer (in hints), and to change the position y[i] by the timer, when the block is checked to be correct will the input or falling to the bottom to the canvas, then we set the block back to the top. The text words are changed randomly from the list. All these blocks are on the canvas, and are regarded as canvas children to do the method like set top. (to change their position)
Input box:
First we can detect the every time the change of the text ¡§Textchange¡¨, then have the judgment whether there is a matching. If matched then clear the input box. 
Time:
Just using the time counter to record time. Begin with 30 seconds.
Health:
Anytime when a block goes to the bottom, health-1, and anytime we match a red word, health+1.
Score:
A match during the time interval, score+1.
Others: I use¡¨ navigate ¡§to change the page to change windows. 
After stating the project, the first page is a welcome page then click ¡§start¡¨ to go to the next page. The next page is the playing part, a hint: shows the red one goes faster and can get bonus. Then click start, then the whole project begin and we match different blocks to the code and detect every change on text health and time.  Then when the game end it goes to game over which will navigate to the last page , to show your score and health.



