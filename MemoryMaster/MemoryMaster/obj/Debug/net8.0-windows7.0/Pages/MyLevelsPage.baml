   M S B A M L   `   `   `  ����G  CMemoryMaster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MemoryMaster.PagesMemoryMaster.Pages  5   	   %    MemoryMaster.Pages.MyLevelsPage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MemoryMaster.Pages     5   	      myLevels  � Title#  �   5   	   $	��400��6,   $	��650��69    � Icon$ /Resources/logoIcon.png��6E    � 
ResizeMode$ CanMinimize=�6d    � WindowStartupLocation$ CenterScreen=�6}   ��5	      �� 5
   
    �� ImageSource$" ../Resources/levelsImage.jpg��6    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/MemoryMaster;component/Resources/Styles.xaml?�6%   %    5      .��5      � .+�5      �� -   5         ��Name$ textBox��5        RoundedTextBoxStyle#��[ 6'   $��10,10,338,324q�6T   6k   �� 5   
   -   5        	 ��Name$	 mainMenuBtn��5        MainMenuButtonStyle#��[ 6'     mainMenu#���  6T   $
��Left=�6y   $��
29,315,0,0q�6�   $	��Top=�6�   6�   �� 5   
   
 �� CornerRadius$
 15��6   $
��Left=�6#   $	��Top=�6>   $��
323,60,0,0q�6V   $	��250��6j   $	��250��6v   $��1��6�   ._�5      � .+�5      �� ���	#FFF7F7F7 J� Opacity$	 0.3Q�6-    �� RadiusX$ 15��6;    �� RadiusY$ 15��6H   $��27,0,-59,10q�6U   �� 5      -   5        $	 playBtn��5        PlayButtonStyle#��[ 6*     play#���  6S   $��Center=�6t   $��
85,190,0,0q�6�   $	��Top=�6�   ���	#FF071241$��Comic Sans MS)�6�   $
��Bold"�6�   $��18(�6  
������� K� ZIndex$ 2��6=  �� 5      -   5         ��Name$ highScoreLbl��5        	highScore#���  6.   $��	40,90,8,0q�6T   $��Comic Sans MS)�6g   $
��Bold"�6�   $��15(�6�   �� 5      -   5        $ 	resultLbl��5      $��0��6+   $��175,90,-45,0q�67   $��Comic Sans MS)�6M   $
��Bold"�6h   $��14(�6z   �� 5      -   5        $ levelNameLbl��5      $�� ��6.   $��30,20,-50,124q�69   $��Comic Sans MS)�6P   $
��Bold"�6k   $��25(�6}   �� 5       -   5        $ bestTimeLbl��5         bestTime#���  6-   $��
40,130,8,0q�6R   $��Comic Sans MS)�6f   $
��Bold"�6�   $��15(�6�   �� 5!      -   5        $ timeLeftLbl��5!      $��0��6-   $��175,130,-41,0q�69   $��Comic Sans MS)�6P   $
��Bold"�6k   $��15(�6}   5"      5#      �� 5%   
   $
 15��6   $
��Left=�6#   $	��Top=�6>   $��	12,60,0,0q�6V   $	��250��6i   $	��250��6u   $��1��6�   ._�5&      � .+�5(      �� ���	#FFF7F7F7$
 0.35Q�6-   $ 15��6<   $ 15��6I   $��
0,0,-10,10q�6V   �� 5)      -	   5        $ 	lblLevels��5)        myLevel#���  6+   $��75, 0,-19,-8q�6O   $��Comic Sans MS)�6e   $
��Bold"�6�   $��20(�6�   �� 5*      $
��Auto=�6   $��	0,39,0,10q�6B   $
��Left=�6U   $	��281��6p   .��5+      �� -
   5        $��levelsStackPanel��5+   !   5.      5/      50      51      53      54      