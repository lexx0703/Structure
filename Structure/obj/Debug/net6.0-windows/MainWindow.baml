   M S B A M L   `   `   `  ����D  @Structure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Structure	Structure  5   	       Structure.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Structure     5   	     � Title$  ToolApp��5   	   $
��auto��6   $
��auto��6'   $	��380��64   $��189.96��6C   .��5	      � -   5         �Name$ DataGrid��5	       � ColumnDefinitions 5
   
   �� 5      $
��157* �6   �� 5      $
��507* �6   .+�5   
   � $��	0,174,0,0q�6    � Cursor$ Cross��6[   $��2��6j   ��6"   ��  �� ElementName$ Products�� �� Mode$ OneWay=� 5      �� 5      $
��auto �6#   �� 5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ Products��5      $��10,-119,10,10q�6*      AutoGenerateColumns$ False��6A   $��5,5,5,5q�6t   $��2��6�   
���   �
���   �
�������$��Consolas)�6�      	CellStyle 5      �� 5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   
IsReadOnly$
 False��6K      Header$ 
Номер��6_      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6n   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ��  �� Path$ Number�6}     5      $
 False��6I   $ Название��6^   $
 auto 6p    6)   �� $
 Name�6     5      $
 False��6K   $ Количество��6_   $
 auto 6s    6)   �� $ Amount�6�     5      $
 False��6K   $ Вес кг��6_   $
 auto 6o    6)   �� $ Weight�6~     5      $
 False��6J   $ Цена ₽��6^   $
 auto 6n    6)   �� $ Price�6}     5      $
 False��6M   $7 1Грузоподъёмность (От 1000 кг)��6a   $
 auto 6�    6)   �� $ Capacity�6�     5      $

 True��6R   $/ )Допустимое количество��6e   $
 auto 6�      
Foreground
 ����� 6)   �� $ AmountAllowed�6�     5      $

 True��6M   $' !Максимальная цена��6`   $
 auto 6{   
 ����� 6)   �� $ MaxPrice�6�   5!      5"      �� 5#   
   -   5         ��Name$ Button1��5#      $��Обновить��6"   $
��Left=�65   $��	10,10,0,0q�6P   $	��Top=�6c   $	��160��6�   $��30��6�   $
}�True��6�   $��2,2,2,2q�6�   
���   �
�������
���   �$��Consolas)�6  $
��Bold"�6&  $��2��68   J� Effect 5$      3  -System.Windows.Media.Effects.DropShadowEffect  5%      5'      �� 5(   
   -   5        $ Button2��5(      $��Экспорт��6"   $��Right=�64   $��	0,10,10,0q�6P   $	��Top=�6c   $	��160��6{   $��30��6�   $
}�True��6�   $��2,2,2,2q�6�   
���   �
���   �
�������$��Consolas)�6  $
��Bold"�6'  $��1��69   5)        5*      5,      5-      5.      