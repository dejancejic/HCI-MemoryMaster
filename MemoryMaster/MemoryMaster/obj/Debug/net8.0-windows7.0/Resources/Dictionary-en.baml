   M S B A M L   `   `   `  ����U  QSystem.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem  5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   	startGame  newLevel  myLevel  chooseLevel  chooseLevelLbl  	InfoLevel 	 score  
levelLabel  play 	 mainMenu 
 time  	highScore  bestTime  prviousBestTime  addLevelTitle  enterLevelName  imagesPicked  levelNameTextSize  	errorText  pickNewImage  addLevel  levelNameEmpty  notEnoughImages  enoughImages  selectCorrectFileType  imageAlreadyExists  
levelAdded  errorInFile  errorWritingFile  levelAlreadyExists  prevousBest  previousTime 	  start ! congradulations " myLevels # sureToDeleteLevel $ confirmation % loading & updateLevel ' 
updateName 
( update ) updateImages * updatedLevel + deletedLevel , success - searchLevel . language / appInfo�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      7System,clr-namespace:System;assembly=System.Runtime  5      %�  &	        &	 "     &	 C     &	 d     &	 �     &	 �     &	 �     &	 �     &	     &		 0    &	
 Q    &	 n    &	 �    &	 �    &	 �    &	     &	 :    &	 _    &	 �    &	 �    &	 �    &	     &	 ?    &	 t    &	 �    &	 �    &	 $    &	 X    &	 �    &	 �    &	 �    &	     &	  C    &	! e    &	" �    &	# �    &	$      &	% $    &	& C    &	' v    &	( �    &	) �    &	* �    &	+     &	, O    &	- n    &	. �    &	/ �    ��5      
Start Game��62   ��5      	Add Level��60   ��5      	My levels��6/   ��5      MemoryMaster - Levels��6?   ��5	      Choose level:��6:   ��5
      Level info:��63   ��5      
Score:��6*   ��5      	Level��6.   ��5      Play��6'   ��5      	Main Menu��60   ��5      	Time:��6(   ��5      High Score:��63   ��5      
Best Time:��61   ��5      Previous Best Time:��6A   ��5       MemoryMaster - Add New Level��6H   ��5      Enter level name��6=   ��5      Picked Images��68   ��5      40Level name mustn't be larger than 20 characters!��6a   ��5      	Error��6-   ��5      Pick New Image��69   ��5      	Add Level��60   ��5       Level name mustn't be empty!��6I   ��5      !Please add at least 2 images!��6K   ��5      #Maximum number of images is 12!��6J   ��5      62Please select a valid image file (jpg, jpeg, png)!��6f   ��5      Image is already added!��6H   ��5       Level is successfully added!��6E   ��5       Error reading the file!��6A   ��5!      Error writing the file!��6F   ��5"      ($Level with that name already exists!��6U   ��5#      Previous Best:��68   ��5$      Previous Best Time:��6>   ��5%      
Start Game��6.   ��5&      Congradulations!��6>   ��5'      MemoryMaster - My Levels��6?   ��5(      /+Are you sure you want to delete this level?��6[   ��5)      Confirmation��67   ��5*      Loading��6-   ��5+      MemoryMaster - Update Level��6E   ��5,      Update Level Name:��6;   ��5-      Update Level��61   ��5.      Update Images��68   ��5/      Successfully updated level!��6F   ��50      Successfully deleted level!��6F   ��51      Success��6-   ��52      Search by level name...��6A   ��53      	Language:��60   ��54      �
�

    Image guessing game (MemoryMaster) 


    MemoryMaster is a game where the user, based on a certain number of cards with pictures on them, tries to find the matching pair of the same pictures and thus reveals the cards until they reveal every combination. 
    

    The application contains several arbitrary levels, ranging from the easiest to the hardest.
        In addition, there is also the possibility for the user to create their own level, that is, to choose their own arbitrary pictures for their new level. For user-defined levels, in addition to displaying all and searching by name, there is also the possibility of changing pictures (removing, updating existing ones, and adding new pictures) and level names. 
    

    For each level, the time to complete the given level is displayed, and upon completion of the level, the number of points the user achieved on that level is displayed, depending on the time taken and the number of correctly guessed pairs and misses.
    

    In addition, for each level, the best result the user achieved on each level is displayed, both in predefined levels in the application and in their own levels.
    

    All pictures are randomly arranged in each level and each time the level is restarted. 

 The application was created in November 2024.
    

 Author: Dejan Ćejić
��5A      5C      