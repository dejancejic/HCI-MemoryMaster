   M S B A M L   `   `   `  ����G  CMemoryMaster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MemoryMaster.PagesMemoryMaster.Pages  5   	   (    "MemoryMaster.Pages.UpdateLevelPage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MemoryMaster.Pages     5   	      updateLevel  � Title#  �   5   	    � WindowState$ 	Maximized=�6/   $	��650��6G   $	��550��6T   $	��650��6`   $	��550��6p    � Icon$ /Resources/logoIcon.png��6    � 
ResizeMode$ 	CanResize=�6�    � WindowStartupLocation$ CenterScreen=�6�   ��5	      �� 5
   
    �� ImageSource$" ../Resources/levelsImage.jpg��6    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/MemoryMaster;component/Resources/Styles.xaml?�6%   %    5      .��5      (� 	 (� Stretch$	 Uniform=�6   .��5   
   � $	��536��6   $	��609��6   .+�5      �� -   5         
 update#���  5        UpdatePageButtonsStyle#��[ 68   $��Center=�6h   $��38��6�   $��	0,550,0,0q�6�   $	��Top=�6�   $	��226��6�   
 J� RenderTransformOrigin$
 0.478,1.738&�6�   $��Comic Sans MS)�6  $
��Bold"�6  $��20(�60  �� 5      -   5         ��Name$ textBox��5        RoundedTextBoxStyle#��[ 6'   $��190,31,70,544q�6T   6k   �� 5        
updateName#���  6   $
��Left=�6;   $��0,35,0,0q�6V   $	��Top=�6h   
�������$��16(�6�   $��Comic Sans MS)�6�   $
��Bold"�6�   �� 5       �� CornerRadius$ 15��6   $��Center=�6'   $��0,40,0,0q�6D   $	��450��6V   $	��400��6b   $��1��6o   ._�5      � .+�5      �� ���	#FFF7F7F7 J� Opacity$
 0.35Q�61    �� RadiusX$ 15��6@    �� RadiusY$ 15��6M   $��
0,-20,0,10q�6Z   �� 5      -   5         ��Name$ updateImages��5        updateImages#���  62   $��Center=�6[   $��	0,-15,0,0q�6x   $��Comic Sans MS)�6�   $
��Bold"�6�   $��20(�6�   �� 5      -   5          pickNewImage#���  5      $
��Left=�6F   $��240,158,0,208q�6a   $	��200��6x   #��[ 6�    K� ZIndex$ 2��6�   �� 5      $
��Auto=�6#   $��	0,30,0,10q�6F   .��5       �� -   5        $��imagesStackPanel��5    %   5!      5"      5#      5$      5%      5&      5'      