   M S B A M L   `   `   `  ����E  AProjectWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjectWPF
ProjectWPF  5   	       ProjectWPF.RegisterWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ProjectWPF     5   	     � Title$  RegisterWindow��5   	    � 
ResizeMode$ NoResize=�6    $	��461��66   $	��333��6C    � WindowStyle$
 None=�6O    � WindowStartupLocation$ CenterScreen=�6b   .��5	      � ���	#FF232437$	��NaN��6"   .+�5
   
   �� -   5         ��Name$ btnback��5
      $��Images/Back.png��6!   $��30��6:   $	��Top=�6E   $��Right=�6]    � Cursor$
 Hand��6y   $��0,-4,0,0q�6�   6�   �� 5   
   $��
80,34,80,0q�6   $��15(�6(   $��School Number Or E-Mail��66   $��Bahnschrift Light)�6U   
������� �� TextAlignment$ Center=�6�   $	��Top=�6�   $��23��6�   �� 5   
   -   5         ��Name$ txtboxRegUN��5      $��
80,58,80,0q�6'    �� 
CaretBrush �	#FF069693$��Bahnschrift Light)�6R   $��15(�6q   
�������$��0,0,0,0q�6�   $	��Top=�6�   ��6   Z� ��6�   Z� 6�   ]� 5   
   $��False��6   $��
80,75,80,0q�6*   
�������$��1��6Q   $	��Top=�6\   �� 5   
   $��15(�6   $��Please Set Password��6"   $��Bahnschrift Light)�6=   $��80,250,80,0q�6\   
�������$ Center=�6�   $��23��6�   $	��Top=�6�   ]� 5   
   $��False��6   $��80,293,80,0q�6*   
�������$��1��6R   $	��Top=�6]   �� 5   
   $��80,329,80,0q�6   $��15(�6)   $��Re-Enter The Password��67   $��Bahnschrift Light)�6T   
�������$ Center=�6�   $��23��6�   $	��Top=�6�   G� 5   
   -   5        	 G�Name$	 pboxreg��5      
 G� 
CaretBrush
 �	#FF069693 G� PasswordChar$ *��6>   $��80,274,80,0q�6O   $��Bahnschrift Light)�6d   $��15(�6�   $��20��6�   ���	#FFF7F7F7$��0,0,0,0q�6�   $	��Top=�6�   ��6�   Z� ��6�   Z� 6�   G� 5   
   -   5        $	 	pboxregag��5      $��80,353,80,0q�6)   
 �	#FF069693$��Bahnschrift Light)�6U   $��15(�6t   
�������$��20��6�   $ *��6�   $��0,0,0,0q�6�   $	��Top=�6�   ��6�   Z� ��6�   Z� 6�   ]� 5   
   $��False��6   $��80,372,80,0q�6*   
�������$��1��6R   $	��Top=�6]    J� RenderTransformOrigin$ 0.5,0.5&�6u   z�5      V� 5      .~�5      ��  �� ScaleY$ -1Q�6%   �� 5      �� 5      T� 5      5      5      �� 5   
   $��80,100,80,0q�6   $��15(�6)   $
��Name��67   $��Bahnschrift Light)�6C   $��23��6b   
�������$ Center=�6�   $	��Top=�6�   �� 5   
   $��80,172,80,0q�6   $��15(�6)   $��Surname��67   $��Bahnschrift Light)�6F   
�������$��23��6x   $ Center=�6�   $	��Top=�6�   �� 5   
   -   5        $ txtboxsurname��5      $��80,196,80,0q�6)    �	#FF069693$��Bahnschrift Light)�6U   $��15(�6t   $��20��6�   
�������$��0,0,0,0q�6�   $	��Top=�6�   ��6�   Z� ��6�   Z� 6�   ]� 5    
   $��False��6   $��80,215,80,0q�6*   
�������$��1��6R   $	��Top=�6]   $ 0.5,0.5&�6u   z�5!      V� 5"      .~�5#      �� $ -1Q�6%   �� 5$      �� 5%      T� 5&      5'      5)      �� 5*   
   -   5        $ 
txtboxname��5*       �	#FF069693$��80,124,80,0q�6=   $��Bahnschrift Light)�6R   $��15(�6q   $��20��6�   
�������$��0,0,0,0q�6�   $	��Top=�6�   ��6   Z� ��6�   Z� 6�   �� 5+   
   -   5         ��Name$ btnRegisterwin��5+   M   $��120,400,120,0q�6   $	��Top=�6)   $��35��6A   ���	#FFE27201$��Calibri)�6|   $��15(�6�   $
��Bold"�6�   $
 Hand��6�   
���   �$��Register��6�   $��0,1,0,0q�6�   ��6�   Z�  J� Effect 5,      3  -System.Windows.Media.Effects.DropShadowEffect  5-      5/      ]� 50   
   $��False��6   $��80,143,80,0q�6*   
�������$��1��6R   $	��Top=�6]   51      52      