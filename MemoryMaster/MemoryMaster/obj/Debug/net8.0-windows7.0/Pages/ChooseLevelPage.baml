   M S B A M L   `   `   `  ����G  CMemoryMaster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MemoryMaster.PagesMemoryMaster.Pages  5   	   7 clr-namespace:MemoryMaster.ModelMemoryMaster.Model  68   (    "MemoryMaster.Pages.ChooseLevelPage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MemoryMaster.Pages     5   	   2model clr-namespace:MemoryMaster.Model     68      chooseLevel  � Title#  �   5	   	   $	��400��6/   $	��600��6<    � WindowStartupLocation$ CenterScreen=�6H    � 
ResizeMode$ CanMinimize=�6m    � Icon$ /Resources/logoIcon.png��6�   ��5
      �� 5   
    �� ImageSource$" ../Resources/levelsImage.jpg��6    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/MemoryMaster;component/Resources/Styles.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��29* �6   �� 5      $
��171* �6   .+�5   
   �� -   5        	 ��Name$	 ChooseLevelLbl��5        chooseLevelLbl#���  6(   $
��Left=�6S   $��31��6n   $��	81,30,0,0q�6z   $	��Top=�6�   $	��134��6�   
�������$��Comic Sans MS)�6�   $��16(�6�   $��2��6�   �� 5   
   -   5        
 ��Name$
 	Level1Btn��5      
 � Tag$ 1��6$     SelectedButtonStyle#��[ 6,   $��1��6Y   $
��Left=�6e   $��41��6�   $��	31,69,0,0q�6�   $	��Top=�6�   $��66��6�   ���	#FF56569A$��Consolas)�6�   $��24(�6�   $
��Bold"�6�   $��2��6-  �� 5   
   -   5        $
 	Level2Btn��5      $ 2��6$     RoundedButtonStyle#��[ 6,   $
��Left=�6X   $��41��6s   $��	28,69,0,0q�6   $	��Top=�6�   $��66��6�   ���	#FF56569A$��Consolas)�6�   $��24(�6�   $
��Bold"�6�   $��2��6  $��1��6,  �� 5   
   -   5        $
 	Level3Btn��5      $ 3��6$   #��[ 6,   $��3��6X   $
��Left=�6d   $��40��6   $	��Top=�6�   $��66��6�   ���	#FF56569A$��Consolas)�6�   $��24(�6�   $
��Bold"�6�   $��
110,69,0,0q�6�   $��1��6-  �� 5    
   -   5        $
 	Level4Btn��5       $ 4��6$   #��[ 6,   $��4��6X   $
��Left=�6d   $��41��6   $��
31,131,0,0q�6�   $	��Top=�6�   $��66��6�   ���	#FF56569A$��Consolas)�6�   $��24(�6�   $
��Bold"�6�   $��2��6-  �� 5!   
   -   5        $
 	Level5Btn��5!      $ 5��6$   #��[ 6,   $
��Left=�6X   $��40��6s   $��
28,131,0,0q�6   $	��Top=�6�   $��66��6�   ���	#FF56569A$��Consolas)�6�   $��24(�6�   $
��Bold"�6�   $��5��6  $��1��6-  �� 5"   
   -   5        $
 	Level6Btn��5"      $ 6��6$   #��[ 6,   $��6��6X   $
��Left=�6d   $��40��6   $	��Top=�6�   $��66��6�   ���	#FF56569A$��Consolas)�6�   $��24(�6�   $
��Bold"�6�   $��110,132,0,0q�6�   $��1��6.  �� 5#   
   -   5        $
 	Level7Btn��5#      $ 7��6$   #��[ 6,   $��7��6X   $
��Left=�6d   $��41��6   $��
31,195,0,0q�6�   $	��Top=�6�   $��66��6�   ���	#FF56569A$��Consolas)�6�   $��24(�6�   $
��Bold"�6�   $��2��6-  �� 5$   
   -	   5        $
 	Level8Btn��5$      $ 8��6$   #��[ 6,   $
��Left=�6X   $��40��6s   $��
28,195,0,0q�6   $	��Top=�6�   $��66��6�   ���	#FF56569A$��Consolas)�6�   $��24(�6�   $
��Bold"�6�   $��8��6  $��1��6-  �� 5%   
   -
   5        $	 levelInfoLabel��5%        	InfoLevel#���  6(   $
��Left=�6N   $��31��6i   $��
303,30,0,0q�6u   $	��Top=�6�   $	��134��6�   
�������$��Comic Sans MS)�6�   $��16(�6�   $��1��6�   �� 5&   
    �� CornerRadius$ 15��6   $
��Left=�6#   $	��Top=�6>   $��
233,90,0,0q�6V   $	��250��6j   $	��250��6v   $��1��6�   ._�5'      � .+�5)      �� ���	#FFF7F7F7 J� Opacity$	 0.3Q�6-    �� RadiusX$ 15��6;    �� RadiusY$ 15��6H   $��
0,-20,0,18q�6U   �� 5*      -   5        $	 levelNumberLbl��5*        
levelLabel#���  60   $��
80,-15,8,0q�6W   $��Comic Sans MS)�6k   $
��Bold"�6�   $��20(�6�   �� 5+      -   5        $	 levelLbl��5+      $��1��6*   $��135,-14,8,0q�66   $��Comic Sans MS)�6K   $
��Bold"�6f   $��20(�6x   �� 5,      -   5        $
 playBtn��5,        PlayButtonStyle#��[ 6+     play#���  6T   $��Center=�6u   $��	0,190,0,0q�6�   $	��Top=�6�    K� ZIndex$ 2��6�   �� 5-      -   5        $
 mainMenuBtn��5-        MainMenuButtonStyle#��[ 6/    	 mainMenu#��� 	 6\   $
��Left=�6�   $��-288,218,0,0q�6�   $	��Top=�6�   6�   �� 5.      -   5        $	 highScoreLbl��5.       
 	highScore#��� 
 6.   $��
10,110,8,0q�6T   $��Comic Sans MS)�6h   $
��Bold"�6�   $��15(�6�   �� 5/      -   5        $	 	resultLbl��5/      $��150,110,8,0q�6r   $��Comic Sans MS)�6�   $
��Bold"�6�   $��15(�6�   ��6+   �� *[0].HighScore+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 50      -   5        $	 levelNameLbl��50      $�� ��6.   $��7,35,8,0q�69   $��Comic Sans MS)�6K   $
��Bold"�6f   $��22(�6x   �� 51      -   5        $	 bestTimeLbl��51        bestTime#���  6-   $��
10,140,8,0q�6R   $��Comic Sans MS)�6f   $
��Bold"�6�   $��15(�6�   �� 52      -   5        $	 timeLeftLbl��52      $��150,140,8,0q�6r   $��Comic Sans MS)�6�   $
��Bold"�6�   $��15(�6�   ��6-   �� *[0].BestTime+$ PropertyChanged=�6�   53      54      57      58      