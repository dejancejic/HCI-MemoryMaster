   M S B A M L   `   `   `  ����  MemoryMaster    MemoryMaster.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MemoryMaster��5   	   $	��350��6   $	��500��6+   $	��350��67   $	��500��6G    � WindowStartupLocation$ CenterScreen=�6V    � WindowState$ 	Maximized=�5	   	    � 
ResizeMode$ 	CanResize=�5
   	    � Icon$ /Resources/logoIcon.png��6    ��5      �� 5   
    �� ImageSource$ Resources/background.jpg��6   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � -   5         �Name$ Overlay��5      
������ $y�	Collapsed=�69   $��3��6P   $��3��6a   	 K� ZIndex$	 10��6u   (� 5   
   $��0��6   $��1��6   $��1��6/   $��Center=�6C   $��Center=�6^   $	��190��6{   .��5       �� $��/Resources/titleImage.png��6   $	��100��67   5!      (� 5#   
   $��1��6   $��1��6   $��Center=�6/   $��Center=�6J   $	��250��6g   .��5$      �� .+�5%      �� -   5        
 ��Name$
 startGameBtn��5%         	startGame#���   6/     StartMenuButtonsStyle#��[ 6U   $
��0,10q�6�   $��40��6�   $	��150��6�   �� 5&      -   5        $
 addLevelBtn��5&        newLevel#���  6.   #��[ 6S   $
��0,10q�6�   $��40��6�   $	��150��6�   �� 5'      -   5        $
 myLevelsBtn��5'        myLevel#���  6.   #��[ 6R   $
��0,10q�6�   $��40��6�   $	��150��6�   5(      5)      �� 5+   
   $��2��6   $��2��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $��Bottom=�6g   $��10q�6�   .+�5-      �� -   5        $
 enBtn��5-      
 � Tag$ en��6$     RoundedImageButtonStyle#��[ 6-   $��0,0,10,0q�6{   .��5.      �� $��Resources/englishIcon.png��6   $��35��6;   $��35��6F   5/      �� 50      -   5        $
 srBtn��50      $ sr��6$   #��[ 51      $��0,0,10,0q�6c   {�50   -   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window.��52      �� $��Resources/serbianIcon.png��6   $��35��6;   $��35��6F   53      54      �� 56   
   -   5        $
 infoBtn��56      $
 info��6"   #��[ 57      $��2��6X   $��0��6e   $
��Left=�6u   $��Bottom=�6�   $��	10,0,0,10q�6�   $��47��6�   $��45��6�   {�56   -   �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window.��58      �� $��/Resources/infoIcon.png��6   $��35��65   $��35��6@   59      �� 5<   
   $ 
Horizontal=�6   $��2��6.   $��1��6;   $��Center=�6K   $��Center=�6h   $��0 0 0 0q�6�   .+�5=      �� -   5        $��
loadingLbl��5=      $y�Hidden=�6&   $��2��6:   $��1��6G     loading#���  6W     LabelH2StyleWhite#��[ 6{   $��18(�6�   $��0 0 0 0q�6�   $��Center=�6�   $��Center=�6�   � 5>      -	   5        $��progressBar��5>      $y�Hidden=�6-    � IsIndeterminate$
 True��5?      
������� % !MaterialDesignCircularProgressBar#��[ 5@       � Value$ 0Q�5A      $��2��6    $��1��6-   $��Center=�6=   $��Center=�6Z   $��0 0 0 0q�6u   5C      5D      5E      