   M S B A M L   `   `   `  ����G  CMemoryMaster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MemoryMaster.PagesMemoryMaster.Pages  5   	   %    MemoryMaster.Pages.MyLevelsPage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MemoryMaster.Pages     5   	      myLevels  � Title#  �   5   	    � WindowState$ 	Maximized=�6,   $	��400��6D   $	��632��6Q    � Icon$ /Resources/logoIcon.png��6]    � 
ResizeMode$ 	CanResize=�6|   $	��400��6�   $	��650��6�    � WindowStartupLocation$ CenterScreen=�6�   ��5	      �� 5
   
    �� ImageSource$" ../Resources/levelsImage.jpg��6    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/MemoryMaster;component/Resources/Styles.xaml?�6%   %    5      .��5      (� 	 (� Stretch$	 Uniform=�6   $��0,0,64,0q�6    .��5   
   � $	��606��6   .+�5      �� -   5        
 ��Name$
 textBox��5        RoundedTextBoxStyle#��[ 6'   $��10,10,338,324q�6T   6k   �� 5      -   5         ��Name$ mainMenuBtn��5        MainMenuButtonStyle#��[ 6*     mainMenu#���  6W   $
��Left=�6|   $��
14,315,0,0q�6�   $	��Top=�6�   6�   �� 5       �� CornerRadius$ 15��6   $
��Left=�6'   $	��Top=�6B   $��
323,60,0,0q�6Z   $	��250��6n   $	��250��6z   $��1��6�   ._�5      � .+�5      �� ���	#FFF7F7F7 J� Opacity$	 0.3Q�61    �� RadiusX$ 15��6?    �� RadiusY$ 15��6L   $��27,0,-59,10q�6Y   �� 5      -   5        $ playBtn��5        PlayButtonStyle#��[ 6.     play#���  6W   $��Center=�6x   $��
85,190,0,0q�6�   $	��Top=�6�   ���	#FF071241$��Comic Sans MS)�6�   $
��Bold"�6�   $��18(�6  
������� K� ZIndex$ 2��6@  �� 5      -   5         ��Name$ highScoreLbl��5        	highScore#���  62   $��	40,90,8,0q�6X   $��Comic Sans MS)�6k   $
��Bold"�6�   $��15(�6�   �� 5      -   5        $ 	resultLbl��5      $��0��6/   $��210,90,-45,0q�6;   $��Comic Sans MS)�6Q   $
��Bold"�6l   $��14(�6~   �� 5      -   5        $ levelNameLbl��5      $�� ��62   $��30,20,-50,124q�6=   $��Comic Sans MS)�6T   $
��Bold"�6o   $��25(�6�   �� 5      -   5        $ bestTimeLbl��5        bestTime#���  61   $��
40,130,8,0q�6V   $��Comic Sans MS)�6j   $
��Bold"�6�   $��15(�6�   �� 5      -   5        $ timeLeftLbl��5      $��0��61   $��210,130,-76,0q�6=   $��Comic Sans MS)�6T   $
��Bold"�6o   $��15(�6�   5       5!      �� 5"      $ 15��6   $
��Left=�6'   $	��Top=�6B   $��	12,60,0,0q�6Z   $	��250��6m   $	��250��6y   $��1��6�   ._�5#      � .+�5$      �� ���	#FFF7F7F7$
 0.35Q�61   $ 15��6@   $ 15��6M   $��
0,0,-10,10q�6Z   �� 5%      -	   5        $ 	lblLevels��5%        myLevel#���  6/   $��75,0,-19,-8q�6S   $��Comic Sans MS)�6h   $
��Bold"�6�   $��20(�6�   �� 5&      $
��Auto=�6#   $��	0,39,0,10q�6F   $
��Left=�6Y   $	��281��6t   .��5'      �� -
   5        $��levelsStackPanel��5'   %   5(      5)      5*      5+      5,      5-      5.      