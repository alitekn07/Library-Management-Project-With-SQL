   M S B A M L   `   `   `  ����E  AProjectWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjectWPF
ProjectWPF  5   	       ProjectWPF.AddBookPanel   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ProjectWPF     5   	     � Title$  AddBookPanel��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��520��6C   $	��450��6P    � AllowsTransparency$
 True��6\    � WindowStyle$
 None=�6v   .��5	      � ���	#FF232437.+�5
   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� .+�5      �� $��	10,10,0,0q�6   $��Bahnschrift Light)�6/   $��Enter Book Name��6N   $��18(�6e   
������� �� TextAlignment$ Center=�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5      -   5         ��Name$ 
txtboxname��5      $��10,0,0,0q�6/   $
��Left=�6A   $	��145��6\   .��6h    5        5      .��5   &   5      �� 5      $��	10,40,0,0q�6   $��Bahnschrift Light)�60   $��Enter Page Number��6O   $��18(�6h   
�������$ Center=�6�    5        5      5      �� 5      -   5        $ txtboxps��5      $��10,0,0,0q�6,   $
��Left=�6>   $	��145��6Y   .��6e    5        5      .��5   &   5       �� 5#      $��	10,40,0,0q�6   $��Bahnschrift Light)�6/   $��Enter Category��6N   $��18(�6d   
�������$ Center=�6�    5$        5%      5'      �� 5(      -   5        $ txtboxcateg��5(      $��10,0,0,0q�60   $
��Left=�6B   $	��145��6]   .��6i    5)        5*      .��5+   &   5,      �� 5/      $��	10,40,0,0q�6   $��Bahnschrift Light)�6/   $��Enter Author Name��6N   $��18(�6g   
�������$ Center=�6�    50        51      53      �� 54      -   5        $ txtboxauthor��54      $��10,0,0,0q�62   $
��Left=�6D   $	��145��6_   .��6k    55        56      .��57   &   58      �� 5;      $��	10,40,0,0q�6   $��Bahnschrift Light)�60   $��Enter Book Year��6O   $��18(�6f   
�������$ Center=�6�    5<        5=      5?      �� 5@      -   5        $ 
txtboxyear��5@      $��10,0,0,0q�6/   $
��Left=�6A   $	��145��6\   .��6h    5A        5B      .��5C   &   5D      �� 5G      $��	10,40,0,0q�6   $��Bahnschrift Light)�60   $��Number of Books��6O   $��18(�6f   
�������$ Center=�6�    5H        5I      5K      �� 5L      -   5        $ txtboxnumbook��5L      $��10,0,0,0q�61   $
��Left=�6C   $	��145��6^   .��6j    5M        5N      .��5O   &   5P      5R      �� 5T      $��	135,0,0,0q�6   $ Vertical=�6-   $	��142��6D   .+�5U      �� -   5         ��Name$ btnadd��5U      $��0,10,0,0q�6)   $��50��6;   $��Bahnschrift Light)�6H   $��20(�6g   $
��Save��6u   ���	#FFF1EFF1
���   �$	��137��6�   ��6�   Z�  5V        5W      5Y      �� 5Z      -   5        $ btnopenlist��5Z      $��	0,170,0,0q�6.   $��50��6A   $��Bahnschrift Light)�6N   $��14(�6m   $��Open Book List��6{   ���	#FFF1EFF1
���   �$	��137��6�   ��6�   Z�  5[        5\      5^      �� 5_      -	   5        $ btnback��5_      $��	0,180,0,0q�6+   $��50��6>   $��Bahnschrift Light)�6K   $��20(�6j   $
��Back��6x   ���	#FFE27201
���   �$	��137��6�   ��6�   Z�  5`        5a      5c      5d      5e      5h      5i      