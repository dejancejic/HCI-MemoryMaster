   M S B A M L   `   `   `  ����  MemoryMaster    MemoryMaster.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MemoryMaster��5   	   $	��350��6   $	��500��6+    � WindowStartupLocation$ CenterScreen=�67    � 
ResizeMode$ CanMinimize=�6\    � Icon$ /Resources/logoIcon.png��6u   ��5	      �� 5
   
    �� ImageSource$# Resources/backgroundImage.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��61* �6   �� 5      $
��339* �6   .+�5   
   � -   5        $��progressBar��5      $y�Hidden=�6)    � IsIndeterminate$
 True��5      
������� %  !MaterialDesignCircularProgressBar#��[  5       � Value$ 0Q�5      $��115,241,262,49q�6   $��1��6#   �� 5   
   -   5         ��Name$ startGameBtn��5        	startGame#���  6'   $
��Left=�6M   $��114,100,0,0q�6h   $	��Top=�6}     StartMenuButtonsStyle#��[ 6�   $��1��6�   6�   �� 5   
   -   5        $ addLevelBtn��5        newLevel#���  6&   $
��Left=�6K   $	��Top=�6f   #��[ 6   $��1��6�   $��114,200,0,0q�6�   6�   �� 5   
   -   5        $ myLevelsBtn��5        myLevel#���  6&   $
��Left=�6J   $	��Top=�6e   #��[ 6~   $��114,150,0,0q�6�   $��1��6�   6�   � 5   
   $��301,240,10,18q�6   $��1��6&   .+�5      �� $��1��6     language#���  6$     LabelH2StyleWhite#��[ 6I   $��Center=�6t   $��	0,-10,0,0q�6�   $	��Top=�6�   5      �� 5"   
   -   5        $ enBtn��5"      
	 � Tag$	 en��6      RoundedImageButtonStyle#��[ 6)   $
��Left=�6Z   $��313,258,0,0q�6u   $	��Top=�6�   $��1��6�   .��5#      �� $��Resources/englishIcon.png��6   $��35��67   $��35��6B   5$      �� 5%   
   -   5        $ srBtn��5%      $	 sr��6    #��[ 5&      $
��Left=�6B   $��356,258,0,0q�6]   $	��Top=�6r   $��1��6�   {�5%   )   �� *DataContext.ControlsEnabled+
 �� RelativeSource
 �� *FindAncestor+ �� AncestorType
 Window.��5'      �� $��Resources/serbianIcon.png��6   $��35��67   $��35��6B   5(      �� 5)   
   -   5        $ infoBtn��5)      $
	 info��6"   #��[ 5*      $��Center=�6B   $��	0,258,0,0q�6_   $	��Top=�6r   {�5)   -   �� *DataContext.ControlsEnabled+
 �� *FindAncestor+
 Window.��5,      �� $��/Resources/infoIcon.png��6   $��30��65   $��30��6@   5-      �� 51   
   -   5        $��
loadingLbl��51      $y�Hidden=�6"   $��1��66     loading#���  6F   #��[ 6j   $��146,234,140,10q�6�   $��18(�6�   �� 53   
   $��/Resources/titleImage.png��6   $	��100��63   $��25,-4,2,238q�6@   $��2��6U   54      55      