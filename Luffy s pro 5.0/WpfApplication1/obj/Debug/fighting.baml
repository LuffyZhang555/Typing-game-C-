   M S B A M L   `   `   `  ����  WpfApplication1    WpfApplication1.Page1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  Playing Game��5      .��5
      �  � RowDefinitions 5   
   �� 5      $
��325* �6   �� 5      $	��13* �6   �� 5      $��2* �6   ��5   
   �� 5       �� ImageSource$. (/WpfApplication1;component/image/pc2.jpg��6   5      .+�5   
   ]� $��0,0,20,0q�6   .+�5       � -   5          �Name$
 play��5      $��	0,0,0,-31q�6"   $	��600��65   $	��500��6A   $	��Top=�6N   5      �� 5   
   -   5        $
��hint��5      $
��hint��6   $��41��6,   $��	0,260,0,0q�68   $	��Top=�6K   $	��119��6c   6o   �� 5   
   -   5         ��Name$ timecountformat��5      $��Time:��6-   $
��Wrap=�6:   $��
10,235,0,0q�6N   $
��Left=�6b   $	��Top=�6}   $��	ExtraBold"�6�   $��20(�6�   ���	#FFF3FF7F$��27��6�   $��52��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ White��6#   $ 1Q�61   5      5!      �� 5"   
   -   5        $ 	timecount��5"      $�� ��6'   $
��Wrap=�6/   $��
79,236,0,0q�6C   $
��Left=�6W   $	��Top=�6r   $��20(�6�   
���  ��$��	ExtraBold"�6�   $��27��6�   $��51��6�   �� 5#   
   -   5        $ HPformat��5#      $��Health:��6&   $
��Wrap=�65   $��
10,260,0,0q�6I   $
��Left=�6]   $	��Top=�6x   $��	ExtraBold"�6�   $��20(�6�   
������$��27��6�   $	��118��6�   ��5$      �� 5%      $ 0.5,1&�6&   $ 0.5,0&�67   .��5&      � $ Black��6#   $ 0Q�61   � 5'      $ White��6#   $ 1Q�61   5(      5*      �� 5+   
   -   5        $ HP��5+      $�� ��6    $
��Wrap=�6(   $��144,260,0,0q�6<   $
��Left=�6Q   $	��Top=�6l   $��	ExtraBold"�6�   $��20(�6�   
���  ��$��27��6�   $��44��6�   �� 5,   
   -   5        	 ��Name$	 inputbox��5,      
 �� TextWrapping$

 Wrap=�6$   $��360,260,0,0q�68   $
��Left=�6M   $	��Top=�6h   $�� ��6�   $	��100��6�   $��22��6�   �� 5-   
   -   5         ��Name$ start��5-      $��Start!��6    $
��Left=�61   $	��Top=�6L   $��197,126,0,0q�6d   $	��125��6y   $��50��6�   
����  �$
��Bold"�6�   ���	#FF9EE439$��Showcard Gothic)�6�   $��36(�6  ��5.      �� 5/      $	 0,1&�6&   $	 0,0&�65   .��50      � $ 	#FFF3F3F3��6#   $ 0Q�65   � 51      $ 	#FFEBEBEB��6#   � 52      $ 	#FFDDDDDD��6#   � 53      $ 	#FFF70FA3��6#   54      56      �� 57   
   -	   5         ��Name$ Canvas��57      $
��Left=�6!   $	��Top=�6<   $	��503��6T   $	��236��6`   $��12,0,0,0q�6m   .+�58      �� -
   5        $
 box1��58      $
��Left=�6&   $	��Top=�6A   $��20��6Y   $��65��6e   
������� �� Left$ 15��6�   
 �� Top$ 10��6�   $
��Bold"�6�   $��12(�6�   �� 59      -   5        $
 box2��59      $
��Left=�6&   $	��Top=�6A   $��20��6Y   $��65��6e   
�������$	 111��6�   $ 10��6�   $
��Bold"�6�   $��12(�6�   �� 5:      -   5        $
 box3��5:      $
��Left=�6&   $	��Top=�6A   $��20��6Y   $��65��6e   
�������$	 216��6�   $ 10��6�   $
��Bold"�6�   $��12(�6�   �� 5;      -   5        $
 box4��5;      $
��Left=�6&   $	��Top=�6A   $��20��6Y   $��65��6e   
�������$	 310��6�   $ 10��6�   $
��Bold"�6�   $��12(�6�   �� 5<      -   5        $
 box5��5<      $
��Left=�6&   $	��Top=�6A   $��20��6Y   $��65��6e   
�������$	 403��6�   $ 10��6�   $��12(�6�   $
��Bold"�6�   $��Tahoma)�6�   ���	#FFD810106�   5>      5?      5@      