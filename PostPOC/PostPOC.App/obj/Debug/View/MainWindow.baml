   M S B A M L   `   `   `  ����F  BPostPOC.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PostPOC.AppPostPOC.App  5   	       PostPOC.App.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:PostPOC.App     5   	     � Title$  
MainWindow��5	   	   $��1297.003��6   $��1753.337��6.   ���	#FF3E3131 � WindowState$ 	Maximized=�6V    � WindowStartupLocation$ CenterScreen=�6n    � DataContext 5   	   �� *	ViewModel+ �� Mode$ TwoWay=� �� RelativeSource �� *Self+.��5
      �  � RowDefinitions 5   
   �� 5      $	��53* �6   �� 5      $
��268* �6   .+�5   
   �� -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��35,1,0,0q�6B   $
��Wrap=�6T   $
��Post��6h   $	��Top=�6t   ���	#FFFCFAFA$��39(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ MainDataGrid��5      	   AutoGenerateColumns	 .  $��1��5   t   ��5   )   �� 
 �� Path$
 Posts� �� SelectedItem 5      �� $
 SelectedPost�$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+  5      $ title��6%    64   �� *title+  5      $
 body��6%      
Visibility$ 	Collapsed=�63    6J   �� *body+   RowDetailsTemplate 5      �� 5      5      5      5!      5"      