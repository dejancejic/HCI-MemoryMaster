   M S B A M L   `   `   `  ����G  CMemoryMaster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MemoryMaster.PagesMemoryMaster.Pages  5   	   %    MemoryMaster.Pages.AddLevelPage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ,local clr-namespace:MemoryMaster.Pages  5   	      addLevelTitle  � Title#  �   5	   	   $	��400��61   $	��600��6>    � WindowStartupLocation$ CenterScreen=�6J    � 
ResizeMode$ CanMinimize=�6o    � Icon$ /Resources/logoIcon.png��6�   ��5
      �� 5   
    �� ImageSource$" ../Resources/levelsImage.jpg��6    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/MemoryMaster;component/Resources/Styles.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $	��97* �6   .+�5   
   �� -   5        	 ��Name$	 textBox��5      $��Comic Sans MS)�6#     RoundedTextBoxStyle#��[ 6>   $��14,31,370,292q�6k   $��1��6�   6�   �� 5   
   -   5        
 ��Name$
 pickImageBtn��5        AddPageButtonsStyle#��[ 6'     pickNewImage#���  6T   $
��Left=�6}   $��329,305,0,0q�6�   $	��Top=�6�   $��1��6�   �� 5   
   -   5        $
 mainMenuBtn��5        MainMenuButtonStyle#��[ 6&     mainMenu#���  6S   $
��Left=�6x   $��
15,305,0,0q�6�   $	��Top=�6�   $��1��6�   �� 5   
   -   5        $
 addLevelBtn��5      #��[ 5        addLevel#���  5       $
��Left=�6'   $��
15,112,0,0q�6C   $	��Top=�6W   $��1��6�   �� 5!   
    �� CornerRadius$ 15��6   $
��Left=�6#   $	��Top=�6>   $��
300,50,0,0q�6V   $	��250��6j   $	��250��6v   $��1��6�   ._�5"      � .+�5#      �� ���	#FFF7F7F7 J� Opacity$
 0.35Q�6-    �� RadiusX$ 15��6<    �� RadiusY$ 15��6I   $��
0,-20,0,18q�6V   �� 5$      -   5         ��Name$ levelNumberLbl��5$        imagesPicked#���  60   $��
50,-15,8,0q�6Y   $��Comic Sans MS)�6m   $
��Bold"�6�   $��20(�6�   �� 5%      $
��Auto=�6   $��
0,20,-5,20q�6B   .��5&      �� -   5        $��ImagesStackPanel��5&   !   5)      5*      5+      5,      5-      5.      