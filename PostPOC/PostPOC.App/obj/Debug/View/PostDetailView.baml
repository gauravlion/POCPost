   M S B A M L   `   `   `  ����F  BPostPOC.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PostPOC.AppPostPOC.App  5   	        PostPOC.App.PostDetailView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:PostPOC.App     5   	     � Title$  PostDetailView��5   	   $��261.221��6    $��537.101��61    � WindowStartupLocation$ CenterScreen=�6A   .��5
      � -   5         �Name$ MainGrid��5
       � RowDefinitions 5   
   �� 5      $	��85* �6   �� 5      $	��31* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ MainDataGrid��5      $��0,0,0.429,0.286q�6S   ��6)   ��  �� Path$ SelectedPost�6o   �� 5   
   -   5         ��Name$ button��5      $��Ok��6!   $
��Left=�6.   $	��Top=�6I   $��75��6a   $��21��6�   $��319,33.714,0,0q�6�   $��1��6�   �� 5   
   -   5        $ button1��5      $��	Copy Html��6"   
 � Tag$
 Html��66   $
��Left=�6U   $��22,18.714,0,0q�6p   $��1��6�   $	��Top=�6�   $��75��6�   $��20��6�   �� 5   
   -   5        $ button2��5      $��	Copy Text��6"   $
 Text��66   $
��Left=�6U   $��112,18.714,0,0q�6p   $��1��6�   $	��Top=�6�   $��75��6�   $��20��6�   �� 5   
   -   5        $ button3��5      $��
Copy Jason��6"   $ Jason��67   $
��Left=�6W   $��206,18.714,0,0q�6r   $��1��6�   $	��Top=�6�   $��75��6�   $��20��6�   5      5      