Hey! Its me Axolotl, this is the first time I worked in C# and Unity, so a lot of this is gonna be messed up, overcomplicated or just weird solutions
Im gonna leave a few notes about my codes, I know I can leave them in the code itself but I keep either forgetting or just hate to overthink while coding

Just learned that I had to place .CS or .MD here in github, also im gonna leave a space in between notes so you guys have a reference of time
Im doing a small proyect that I called Portafolio, but unoficcialy its just Time, I loved the time travel mechanic from TitanFall 2
So im doing somenthing similar in a way? just like travel in dimensions that have small diferences, and do a puzzle like portal kinda gameplay?
I ran into a few issues while working on the proyect, like the time travel mechanic, what I did was just make a paralel map, that is a 1:1 copy of the other map
there is a second ghost player that keeps track of where the player is and recreates it on the second map, the time travel feature is just a teleport to the ghost
and the ghost teleports to the player possition the first issue that I came to is that the teleport would make the ghost go to the player and they would become one
or the player would teleport to the ghost and make the same issue, making the teleport a one way trip or just break, the solution I did was add a reference point
inside the body of the ghost and one on the player, so the teleport would consistently go! the second issue was  that the reference point, wouldnt change...
the solution for me was to add the teleport.cs script to work and move with the body! wich would go back to error one of creating the one body issue,
I know there is probably more ways to fix it, but how I Fixed it was doing TeleportReference.cs that would do almost the same as Teleport.cs but just adding a 0.016ms
(1frame) delay for the reference points, wich makes the teleportation be instant and not break, you can even spam it and its always gonna keep track!
now for the teleportation to look more natural I just did a white image in a canvas, and used Flash.cs to make a small teleport effect, the only issue
that flash.cs has rn is that if you spam it the effect turns weird, so I might add a small cooldown for the teleport, also, the new issue I have is in regards
of the ghost, the ghost as it shares the same properties as the main body it cant go thru walls, and since the puzzle is about traveling back and forth to
do the puzzle its hard if you cant travel back and forth in the same place your standing on... well ill fix it tomorrow, I finished working on the github
and the flash.cs while I was watching spy x family with my wife, good night!

I lied I fixed partially I just cahnged the collision matrix, now I need to find a way of not teleporting if the ghost is on a solid object

A lot happened, I just stopped doing the second character moving with the controllers and made the ghost move with a new script that is just the player possition
 + or - off set depending in what timeline he is on, ill be updating the new FPController.cs since there was a issue with the camera rotation on the X axis just messing
the off set so I just updated it and also made the new code GhostMovement.cs, the game mechanic looks good so far so now I just have to do some small level desings
animations and sound effects, ill update back later
