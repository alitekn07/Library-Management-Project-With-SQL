   M S B A M L   `   `   `  ����E  AProjectWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjectWPF
ProjectWPF  5   	       ProjectWPF.StudentPanel   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ProjectWPF     5   	     � Title$  StudentPanel��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��450��6C   $	��800��6P    � AllowsTransparency$
 True��6\    � WindowStyle$
 None=�6v   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   5      �� 5      $��2* �6   5      .+�5   
   �� $��0��6   ���	#FF232437._�5      �� .+�5      �� -   5         ��Name$ 	lblLogged��5      $��Bahnschrift Light)�6@   $��18(�6_   $��Center=�6m   $��0,20,0,0q�6�   ��6/   �� 6�   �� 5      -   5         ��Name$ 	btnrebate��5   1   ���	#FFF1EFF1$��Bahnschrift Light)�6[   $��20(�6z   
���   �$��Return The Book��6�   $	��250��6�   $��0,60,0,0q�6�    � Cursor$
 Hand��6�   $��0,0,0,0q�6�   ��6�   Z�  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5      -   5        $ 
btngetbook��5   2   ���	#FFF1EFF1$��Bahnschrift Light)�6]   $��20(�6|   
���   �$��Rent a Book��6�   $	��250��6�   $��0,60,0,0q�6�   $
 Hand��6�   $��0,0,0,0q�6�   ��6�   Z�  5        5       5"      �� 5#      -   5        $ btntookbooks��5#   4   ���	#FFF1EFF1$��Bahnschrift Light)�6a   $��20(�6�   
���   �$��Books I Rent��6�   $	��250��6�   $��0,60,0,0q�6�   $
 Hand��6�   $��0,0,0,0q�6�   ��6�   Z�  5$        5%      5'      �� 5(      -   5        $ btnback��5(   /   ���	#FFE27201$��Bahnschrift Light)�6W   $��20(�6v   
���   �$
��Exit��6�   $	��250��6�   $��0,60,0,0q�6�   $��0,0,0,0q�6�   $
 Hand��6�   ��6�   Z�  5)        5*      5,      5-      5.      �� 51   
   $��1��6   ���	#FFF1EFF153      55      56      