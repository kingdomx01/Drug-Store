   M S B A M L   `   `   `  ����  	DrugStore    DrugStore.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$  
Drug Store��5   	   $	��600��6   $	��900��6)    � WindowStartupLocation$ CenterScreen=�5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5
      $��2* �6   .+�5   
   �� -   5         ��Name$
 Menu��5   B   $
��Left=�6   ���	#FF007ACC$��-20,0,542,0q�6P   $��0��6e   .+�5      d� -   5         d�Name$ menuTreeviewToggleButton��5      ���	#FF007ACC���	#FF007ACC$��0q�5   J   $��10q�5      $	��109��6(    J� RenderTransformOrigin$ 0.723,0.559&�64   ��5      �� 5       �� 
TargetType" d�6&   .R�5      �� #��z��6!   #��z��6K   #��z��5   !    �� Padding# z��6U   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      .��5      �� $	����6   
�������$��18(�5   2   $��Segoe MDL2 Assets)�6@   5      R� 5      -   5         R�Name$ menuTreeview��5      $��	10,0,10,0q�6-   
������ $��0q�5    1   $	��345��6E   $	��127��6R   $��Disabled=�5!      $��Disabled=�5"      ��5      �� *
Background+	 �� ElementName$	 menuTreeviewToggleButton����5#      �� 5$      
 �� 
TargetType"
 Q�6   .�5%      ��  �� Property � �� �� Value 5&      �� 5'   "   .R�5(   &   �� $��5q�6A   $��Center=�6L   
���������60   �� 6g   5)   #   5+       �� Triggers 5,      P� 5-       P� Property �@J�IsMouseOver P� Value . . �5.   "   ��  � ��
 �����6?   �� 5/   "    � ��
 �   �6?   50      52      .@�57      Q� -   5         Q�Name$ NewOrderItem��57   2   $��	New Order��6   $��	0,20,0,10q�6H   $��3��6[   
 � Tag$ NewOrderWindow��6h   $��Center=�6}   ��58      �� 59      .R�5:      ��  �� Orientation$ 
Horizontal=�6)   .+�5;   "   ��  ��Name$ NewOrder_Text��6,   $��Center=�5=   ,   
�������$y�	Collapsed=�5?   ,   ��5<   ,   �� 5?   ,   �� 5@   "    ��Name$ NewOrderIcon��6(   $'��!Resources\Icon\New_Order_Icon.png��5A   )      	IconStyle#��[  5B   )   $y�Visible=�6L   5C      5D      5F      Q� 5H      -   5        $ InventoryItem��5H   2   $��	Inventory��6   $��	0,20,0,10q�6I   $��2��6\   $ InventoryWindow��6i   ��5I      �� 5J      .R�5K      �� $ 
Horizontal=�6)   .+�5L   "   �� $ Inventory_Text��6,   $��Center=�5N   ,   
�������$y�	Collapsed=�5P   -   ��5M   ,   �� 5P   -   �� 5Q   "   $ InventoryIcon��6(   $'��!Resources\Icon\Inventory_Icon.png��5R      #��[  5S      $y�Visible=�6;   5T      5U      5W      Q� 5Y      -   5        $ FinanceItem��5Y   0   $��Finance��6   $��0��6E   $��	0,20,0,10q�6R   $ FinanceWindow��6e   ��5Z      �� 5[      .R�5\      �� $ 
Horizontal=�6)   .+�5]   "   �� $ Finance_Text��6,   $��Center=�5_   ,   
�������$y�	Collapsed=�5a   ,   ��5^   ,   �� 5a   ,   �� 5b   "   $ FinanceIcon��6(   $%��Resources\Icon\Finance_Icon.png��5c      #��[  5d      $y�Visible=�6;   5e      5f      5h      Q� 5j      -   5        $ Settings��5j   1   $��Settings��6   $��	0,20,0,10q�6C   $��4��6V   $ SettingUserControl��6d   ��5k      �� 5l      .R�5m      �� $ 
Horizontal=�6)   .+�5n   "   �� $ Customer_Text��6,   $��Center=�5p   ,   
�������$y�	Collapsed=�5r   ,   ��5o   ,   �� 5r   ,   �� 5s   "   $ CustomerSupportIcon��6(   $!��Resources\Icon\Settings.png��5t   %   #��[  5u   %   $y�Visible=�6H   5v      5w      5y      5{      5}      � 5   
   -   5         �Name$ Content��5   6   $��	132,0,0,0q�6   $��2��6"   .+�5�      � $��	-16,0,0,0q�6   5�       � 5�      -	   5          �Name$ 	MainFrame��5�        � NavigationUIVisibility$ Hidden=�6'   $��-9,0,0,0q�6G   5�      5�      5�      