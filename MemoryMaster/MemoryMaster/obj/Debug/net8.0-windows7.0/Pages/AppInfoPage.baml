   M S B A M L   `   `   `  ����G  CMemoryMaster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MemoryMaster.PagesMemoryMaster.Pages  5   	   $    MemoryMaster.Pages.AppInfoPage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MemoryMaster.Pages     5   	   -   5          � Title$
  Info��5   	   $	��350��6   $	��550��6#    � 
ResizeMode$ CanMinimize=�6/    � WindowStartupLocation$ CenterScreen=�6H    � Icon$ /Resources/logoIcon.png��6�   ��5	      �� 5
   
    �� ImageSource$&  ../Resources/backgroundImage.jpg��6   .��5      � .+�5   
   �� $��Hidden=�6   .��5      �� -   5         ��Name$ ScrollingText��5      $
��Wrap=�6/   $��16(�6C   
�������$��Bottom=�6d      appInfo#���   6   $��25q�6�   z�5      T� 5       T� Y$ 0Q�6)   5      5       � Triggers 5   
   :� 5       :� RoutedEvent$ Window.Loaded��6   .[�5      �� .��5      �� .��5      W� 	 �� 
TargetName$	 ScrollingText��5      
 �� TargetProperty$8
 2(UIElement.RenderTransform).(TranslateTransform.Y)�5       W� From 2005      	 W� To -6006(    g� Duration$ 0:0:45D�5       g� RepeatBehavior$ Forever��5      5       5!      5"      5$      5%      