   M S B A M L   `   `   `  ����=  9p2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:p2p2  5          p2.enrtypage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:p2     5        N� Title$  	enrtypage��5	      .��5      � .+�5   
   �� $��IN OUT TIMMING��6   $��Center=�6*   $	��Top=�6G   $��24(�6_   $
��Bold"�6m   
�������
���   �6�   � 5   
   -   5         �Name$ Mygrid��5      $��	0,280,0,0q�6   
�������.+�5      �� $��Vehicle No Plate��6   $
��Bold"�6/   $
��Left=�6B   $��	80,76,0,0q�6]   $	��Top=�6p   $��28��6�   $	��138��6�   �� 5      -   5         ��Name$ cmbVehicleNoPlate��5      $
��Left=�61   $��
216,76,0,0q�6L   $	��Top=�6`   $	��120��6x   
�������6�   �� 5      -   5        $��In��5      $
��Left=�66   $��
400,70,0,0q�6Q   $	��Top=�6e    J� RenderTransformOrigin$ 10.691,0.156&�6}   �� 5      -   5        $	��Out��5      $
��Left=�68   $��
459,70,0,0q�6S   $	��Top=�6g   $ 0.412,0.125&�6   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��mygrid��5         AutoGenerateColumns$ False��6!   $��
0,37,0,170q�6=    � 	Resources 5       �� 
TargetType �� Property �� Value��%X   '��       �� 5       " ��6   .�5!      ��  � �� �#512DA863   5"      5#      	   Columns	 5$      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6%      Header$ Entry ID��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *	EntryId+  5(      $
 * 6%   $ 
Vehicle ID��6/    6C   �� *	VehicleId+  5)      $
 * 6%   $ Entry Date Time��6/    6H   �� *EntryDateTime+  5*      $
 * 6%   $ Exit Date Time��6/    6G   �� *ExitDateTime+   ColumnHeaderStyle 5,      �� 5-      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5.      ��  � �� �#512DA863   �� 5/       � ��
 �����63   �� 50       � ��$ 19(�61   �� 52       � ��$
 Bold"�63   55      57      5;      5<      