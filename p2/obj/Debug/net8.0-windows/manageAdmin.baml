   M S B A M L   `   `   `  ����=  9p2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:p2p2  5          p2.manageAdmin   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:p2     5        N� Title$  manageAdmin��5
      .��5      � .+�5   
   �� $��Registration��6   $��Center=�6(   $	��Top=�6E   $��24(�6]   $
��Bold"�6k   
�������
���   �6�   � 5   
   -   5         �Name$ Mygrid��5      $��	0,230,0,0q�6   
�������.+�5      �� $
��Name��6   $
��Left=�6#   $��10,7,0,0q�6>   $	��Top=�6P   $��28��6h   $��47��6t   $
��Bold"�6�   �� 5      $��Phone��6   $
��Left=�6$   $��	10,35,0,0q�6?   $	��Top=�6R   $
��Bold"�6k   �� 5      $
��CNIC��6   $
��Bold"�6$   $
��Left=�66   $��
260,31,0,0q�6Q   $	��Top=�6e   $��28��6}   $��40��6�    J� RenderTransformOrigin$ 0.617,-0.143&�6�   �� 5      $��Password��6   $
��Bold"�6'   $
��Left=�69   $��	260,7,0,0q�6T   $	��Top=�6g   $��28��6   $��60��6�   �� 5      $
��Role��6   $
��Bold"�6$   $
��Left=�66   $��
499,21,0,0q�6Q   $	��Top=�6e   $��28��6}   $��40��6�   $ 
1.25,0.393&�6�   �� 5      -   5        $��txtPhone��5      $
��Left=�6&   $��	62,35,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��120��6�   
�������6�   �� 5      -   5        $��txtName��5      $
��Left=�6%   $��62,5,0,0q�6@   $
 Wrap=�6R   $	��Top=�6f   $	��120��6~   
�������6�   �� 5      -   5        $��txtCNIC��5      $
��Left=�6%   $��
320,34,0,0q�6@   $
 Wrap=�6T   $	��Top=�6i   $	��120��6�   
�������6�   �� 5      -   5        $��txtPassword��5      $
��Left=�6)   $��	320,4,0,0q�6D   $
 Wrap=�6W   $	��Top=�6l   $	��120��6�   
�������6�   �� 5      -   5         ��Name$ RoleComboBox��5      $��529,21,82,0q�6-   $��22��6B   $	��Top=�6N   .@�5      �� $��Admin��6   �� 5      $��Guard��6   �� 5      $��
SuperAdmin��6   5      �� 5"      -   5        $	��Add��5"      $
��Left=�63   $��	52,89,0,0q�6N   $	��Top=�6a   �� 5#      -   5        $��Delete��5#      $
��Left=�66   $��
244,89,0,0q�6Q   $	��Top=�6e   �� 5$      -	   5        $��Update��5$      $
��Left=�69   $��
428,89,0,0q�6T   $	��Top=�6h   �� 5-      -
   5        $��Search��5-      $��
10,138,0,0q�6;   $
��Left=�6O   $	��Top=�6j   �� 5/      -   5         ��Name$ 	txtSearch��5/      $
��Left=�6)   $��117,142,0,0q�6D   $	��Top=�6Y   $	��200��6q   51      &   System.Windows.Controls.DataGrid  54   
   -   5        $��mygrid��54         AutoGenerateColumns$ False��6!   $��
0,37,0,225q�6=      Columns 55      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%   	   Header$	 ID��6/   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *Id+6T     58      $ * 6%   $
	 Name��6/   
 6=   �� *Name+6X     59      $ * 6%   $	 Phone��6/   
 6>   �� *Phone+6Z     5:      $ * 6%   $
	 CNIC��6/   
 6=   �� *Cnic+6X     5;      $ * 6%   $	 Password��6/   
 6A   �� *
Password+6`     5<      $ * 6%   $
	 Role��6/   
 6=   �� *Role+6X   4  .System.Windows.Controls.DataGridTemplateColumn  5>      $	 Select��6)      CellTemplate 5?      �� 5@      .R�5A      ��  ��Name$ 	chkSelect��6'   $��Center=�6:   $��Center=�6W   5B      5D         ColumnHeaderStyle 5F      �� 5G       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5H      ��  �� Property � �� �� Value �#512DA863   �� 5I       � ��
 �����63   �� 5J       � ��$ 19(�61   �� 5L       � ��$
 Bold"�63   5O      5Q      5S      5T      