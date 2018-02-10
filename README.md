**Game Technologies Lab**

**Haoyun Li**

**Second Project – Random Algorithm in Video Game**

1. **What is the line of inquiry of my first project?**

I used to like playing the game like Pokemon. When the player controls the character in the game, he will meet monster randomly. The player will never know when and where he will meet the monster. So I am wondering how could I realize this effect in a game.

I also like playing Overwatch, when I am opening the loot box, I am curious about how blizzard design the probability algorithm to control the generation of rare and general gears.

That&#39;s why I want to do this project.

1. **The process of exploration**

I plan to do it in Unity. Because the core of my project is design the random algorithm, I should not put so much effort on coding other things. So using Unity is the best way for my project.

The first step is do research on games like Pokemon and Overwatch.

I consider two possibilities algorithm of encountering monster. The first is that monsters are unable to see by player, that means they are transparent. they distribute randomly in the map. So we can&#39;t know when and where we will meet them. The second algorithm is counting steps. More steps you move, higher possibility for you to meet the monster.

I asked my roommate which the right algorithm of the game of Pokemon is, he said Pokemon used the first algorithm and some other game like SFC use second algorithm. That&#39;s why I try both algorithm in my program.

To simulate opening loot box, after researching on the Internet, I use different weights to make different gears have different opportunities to come out.

1. **The process of doing project.**

1. Use Planes to build the floor and walls (which are transparent)
2. Wright moving function
3. Wright random function.

// Only calculate possibility when player move further than 1, and then update the last position.

//if the number was not included the execution range, the range becomes larger.

if(Vector3.Distance(lastPos,this.transform.position)&gt;=1.0f){
            stepNum++;
            Debug.Log (&quot;stepNum&quot;+stepNum);
             **p=p+**** 1.475f ****; //very important**
            float rand = Random.Range (0.0f,100.0f);
            if(rand&lt;p){
                SceneManager.LoadScene (&quot;Dig&quot;);
            }
            lastPos = this.transform.position;

}

1. Go to &quot;Dig&quot; scene. Show the three treasure levels when we click &quot;Dig&quot; button. Using this function showing as below:

//using weights to distribute the different possibilities.

float[] rand = new float[3];
            float tempx = -2;
            for(int i=0;i&lt;3;i++){
                tempx++;
                rand[i] = Random.Range (0.0f,100.0f);
                if(rand[i]&lt;gold){
                    g.transform.position  = new Vector3(tempx, g.transform.position.y, g.transform.position.z);
                    Instantiate (g);
                    Debug.Log (&quot;gold&quot;);
                }else if(rand[i]&lt;blue){
                    b.transform.position  = new Vector3(tempx, b.transform.position.y, b.transform.position.z);
                    Instantiate (b);
                    Debug.Log (&quot;blue&quot;);
                }else{
                    w.transform.position  = new Vector3(tempx, w.transform.position.y, w.transform.position.z);
                    Instantiate (w);
                    Debug.Log (&quot;white&quot;);
                }
            }

1. **The result**

Comparing two algorithms of meeting monster, I find the second one is more &quot;comfortable&quot; and &quot;reasonable&quot; than the first one. If we set the possibility is one third, the first algorithm is too &quot;random&quot;, the second algorithm could hold the situation around one third. Player do not like too &quot;random&quot; but to fit their imagine situations. So in most situations, PRD is better.

About the random algorithm in loot box. Sometimes the best gears appear at same time. It not corresponds with people&#39;s common sense. To improve it, I think I should low down the best gear&#39;s weight after it appears, and increase the weight of other gears&#39; appearing possibilities.

1. **Citation:**

http://gad.qq.com/article/detail/21749

http://huangwei.pro/2015-07/game-random/
