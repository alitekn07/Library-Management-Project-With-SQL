   M S B A M L   `   `   `  ����E  AProjectWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjectWPF
ProjectWPF  5   	   #    ProjectWPF.BookRetrievalPanel   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ProjectWPF     5   	   -   5          � Title$  BookRetrievalPanel��5   	    � WindowStartupLocation$ CenterScreen=�6$   $	��450��6a   $	��800��6n    � AllowsTransparency$
 True��6z    � WindowStyle$
 None=�6�   .��5	      � ���	#FF232437.+�5
   
   �� .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$	 dg1��5      $	��250��6$   61   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� .+�5      �� $ 
Horizontal=�6!   .+�5      �� $��0,10,0,0q�6$   $��22(�66   $��Bahnschrift Light)�6D   $��Name Of Book      :   ��6c   
�������6�   �� 5      -   5        $��
txtboxname��5   [   $��22(�6"   $��Bahnschrift Light)�60   $	��150��6O   6[   5      �� 5      $ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�5      �� $��0,10,0,0q�6$   $��22(�66   $��Bahnschrift Light)�6D   $��Type Of Book        :   ��6c   
�������6�   �� 5      -   5        $��txtboxcateg��5   [   $��22(�6"   $��Bahnschrift Light)�60   $	��150��6O   6[   5      �� 5      $ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�5      �� $��0,10,0,0q�6$   $��22(�66   $��Bahnschrift Light)�6D   $��Search By Letter :   ��6c   
�������6�   �� 5      -   5        $��
txtboxchar��5   [   $��22(�6"   $��Bahnschrift Light)�60   $	��151��6O   6[   5      �� 5      $ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�5      �� $��0,10,0,0q�6$   $��22(�66   $��Bahnschrift Light)�6D   $��Name Of Writer   :   ��6c   
�������6�   �� 5       -   5        $��txtboxauthor��5    [   $��22(�6"   $��Bahnschrift Light)�60   $	��153��6O   6[   5!      5#      �� 5%      $��	150,0,0,0q�6   .+�5&      �� -   5         ��Name$ checkbox��5&      $.��(Don't Include finished books in the list��61   $��Bahnschrift Light)�6d   $��Center=�6�   $��16(�6�   $��0,10,0,0q�6�   
������� � Cursor$  ��6   d� 	IsChecked$ FalseY�6  �� 5'      -   5        	 ��Name$	 	btnsearch��5'   5   $��Search Book��6H   $��0,10,0,0q�6^   $��22(�6p   
���   �$��Bahnschrift Light)�6�   ���	#FF00FFF9$	��250��6�   $��40��6�   $
 Hand��6�   $��0,0,0,0q�6  ��6�   Z� 
 J� Effect
 5(      3  -System.Windows.Media.Effects.DropShadowEffect  5)      5+      �� 5,      -	   5        $	 btnget��5,   2   $��	Rent Book��6B   $��0,10,0,0q�6W   $��22(�6i   
���   �$��Bahnschrift Light)�6�   ���	#FF00FFF9$	��250��6�   $��40��6�   $
 Hand��6�   $��0,0,0,0q�6�   ��6�   Z� 
 5-        5.      50      �� 51      -
   5        $	 btnback��51   3   $
��Back��6D   $��0,10,0,0q�6T   $��22(�6f   
���   �$��Bahnschrift Light)�6�   ���	#FFE27201$	��250��6�   $��40��6�   $
 Hand��6�   $��0,0,0,0q�6�   ��6�   Z� 
 52        53      55      56      58      59      5:      5;      