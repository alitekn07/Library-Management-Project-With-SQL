   M S B A M L   `   `   `  ����E  AProjectWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjectWPF
ProjectWPF  5   	       ProjectWPF.AdminPanel   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ProjectWPF     5   	   -   5          � Title$  
AdminPanel��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��450��6X   $	��800��6e    � AllowsTransparency$
 True��6q    � WindowStyle$
 None=�6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   5      �� 5      $
��2.5* �6   5      .+�5   
   �� ���	#FF232437$��0��6(   ._�5      �� .+�5      �� -   5         ��Name$ 	lblLogged��5      $��25(�6/   $��0,20,0,0q�6=   $��Center=�6`   
���   ���6O   �� 6}   �� 5      -   5         ��Name$ btnadd��5   .   $	��180��6?   $��0,40,0,0q�6K   ���	#FFF1EFF1
���   �$��Add Book��6�   $��0,0,0,0q�6�    � Cursor$
 Hand��6�   $��15(�6�   ��6�   Z�  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5      -   5        $ btnshow��5   /   $	��180��6@   $��0,40,0,0q�6L   ���	#FFF1EFF1
���   �$��
List Books��6�   $��0,0,0,0q�6�   $
 Hand��6�   $��15(�6�   ��6�   Z�  5        5       5"      �� 5#      -   5        $ btntook��5#   /   $	��180��6@   $��0,40,0,0q�6L   ���	#FFF1EFF1
���   �$��Books in Use��6�   $��0,0,0,0q�6�   $
 Hand��6�   $��15(�6�   ��6�   Z�  5$        5%      5'      �� 5(      -   5        $ 	btnaccept��5(   1   $	��180��6D   $��0,40,0,0q�6P   ���	#FFF1EFF1
���   �$��Teacher Approval��6�   $��0,0,0,0q�6�   $
 Hand��6�   $��15(�6�   ��6�   Z�  5)        5*      5,      �� 5-      -   5        $ 	btnlogout��5-   1   $	��180��6D   $��0,40,0,0q�6P   ���	#FFE27201
���   �$
��Exit��6�   $��0,0,0,0q�6�   $
 Hand��6�   $��15(�6�   ��6�   Z�  5.        5/      51      52      53      �� 55   
   ���	#FFF1EFF1$��1��6(   ._�56      �� .+�57      �� $��Notification Panel��6   $��Center=�66   $��25(�6S   $��Bahnschrift Light)�6a   &   System.Windows.Controls.DataGrid  58      -   5        	  Name$	 dg��58      $	��290��6'   �� 59      
 �� Orientation$
 
Horizontal=�6   .+�5:      �� -	   5        $ btnsettings��5:   7   $��Settings��6L   $	��180��6`   $��	40,40,0,0q�6l   ���	#FF00FFF9
���   �$
 Hand��6�   $��0,0,0,0q�6�   $��16(�6�   ��6�   Z�  5;        5<      5>      �� 5?      -
   5        $ 	btnrebate��5?   6   $��Return Confirmation��6I   $	��180��6h   $��
110,40,0,0q�6t   ���	#FF00FFF9
���   �$��0,0,0,0q�6�   $��16(�6�   $��30��6�   ��6�   Z�  5@        5A      5C      5D      5E      5F      5H      5I      