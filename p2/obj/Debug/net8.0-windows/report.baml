   M S B A M L   `   `   `  ����=  9p2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:p2p2  5          	p2.report   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:p2     5        N� Title$  report��5	      .��5      �  J� RenderTransformOrigin$ 0.496,0.712&�6   .+�5   
   �� $��Report Generate��6   $��Center=�6+   $	��Top=�6H   $��24(�6`   $
��Bold"�6n   
�������
���   �6�   � 5   
   -   5         �Name$ Mygrid��5      $��0,334,0,-39q�6   
�������.+�5      �� $��End Date��6   $
��Bold"�6'   $
��Left=�69   $��
205,38,0,0q�6T   $	��Top=�6h   $��28��6�   $��72��6�   �� 5      $��
Start Date��6   $
��Bold"�6)   $
��Left=�6;   $��	46,38,0,0q�6V   $	��Top=�6i   $��28��6�   $��87��6�   $ 	3.064,0.5&�6�   �� 5       �� Orientation$ 
Horizontal=�6   $��10q�62   .+�5      (  "System.Windows.Controls.DatePicker  -   5          Name$ startDatePicker��5      $	��150��66   $ 
0.5,-0.922&�6e      SelectedDate 6B   �� *	StartDate+6e     5      -   5        $ endDatePicker��5      $	��150��64    6@   �� *	EndDate+�� 5      -   5        $��Filter��5      $ 0.516,-0.891&�6L   ��6*   �� *FilterCommand+6q   �� 5      -   5        $��Generate Report��5      63   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��mygrid��5         AutoGenerateColumns$ False��6!   $��
0,37,0,119q�6=   $ 0.5,0.5&�6Q   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ 0.239Q�6$   �� 5      T� 5        T� X$ 0.496Q�6)   5!      	   Columns	 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6%      Header$ Entry ID��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *	EntryId+  5%      $
 * 6%   $ 
Vehicle ID��6/    6C   �� *	VehicleId+  5&      $
 * 6%   $ Entry Date Time��6/    6H   �� *EntryDateTime+  5'      $
 * 6%   $ Exit Date Time��6/    6G   �� *ExitDateTime+   ColumnHeaderStyle 5.      �� 5/       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�50      ��  �� Property � �� �� Value �#512DA863   �� 51       � ��
 �����63   �� 52       � ��$ 19(�61   �� 54       � ��$
 Bold"�63   57      59      5=      5>      