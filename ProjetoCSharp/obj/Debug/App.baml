   M S B A M L   `   `   `  ����H  DProjetoCSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjetoCSharpProjetoCSharp  5          ProjetoCSharp.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -localclr-namespace:ProjetoCSharp     5        �� 	Resources  5       �� MergedDictionaries �� Source   btnTerminal �� 
TargetType �� Property  FocusVisual �� Value �� 
TargetType ��Name J� SnapsToDevicePixels	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName  bkgColor  txtColor  Item.MouseOver.Background �� Color  Item.MouseOver.Border $  Item.SelectedInactive.Background   Item.SelectedInactive.Border " Item.SelectedActive.Background 	 Item.SelectedActive.Border 
 ListBox.Static.Background  ListBox.Static.Border  ListBox.Disabled.Background  ListBox.Disabled.Border  ListViewItemStyle1 �� RelativeSource �� AncestorType �� Padding ]� 
Conditions �� Property �� Value  ListViewStyle1 
 Orange  CinzaUsuarioClaro�� 5	   
    5
      �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   �� 5      $v ppack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Orange.xaml?�6%   �� 5      $y spack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.DeepPurple.xaml?�6%   %  &	        7  &	 ]    &	 ~    &	 �    &	 �    &	 �    &	     &	 +    &		 N    &	
 q    &	 �    &	 �    &	 �    &	 �    7  &	 
    7 
 7  7  7  &	 �    &	     �� 5      " ��6(   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��
 ���� 6+   �� 5       � ��
 ���� 6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � ��$ 1q�6(   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . ._�5       �� $	 contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5!      
 5"      P� 5#   "    �@J�IsMouseOver . . �5$   "   �� $ contentPresenter��6K    � ��
 �����6i   5%      P� 5&       � �� . . �5'   &   �� $ contentPresenter��6O    � �� �	#FFFF98006m   5(      5+      5-      5.      ��5/   
   	#FF1D1B1B��6,   ��50   
   	#FF898080��6,   �� 51   
   $ 	#1F26A0DA��6<   �� 52   
   $ 	#a826A0Da��68   �� 53   
   $ 	#3DDADADA��6C   �� 54   
   $ 	#FFDADADA��6?   �� 55   
   $ 	#3D26A0DA��6A   �� 56   
   $ 	#FF26A0DA��6=   �� 57   
   $ 	#FFFFFFFF��6<   �� 58   
   $ 	#FFABADB3��68   �� 59   
   $ 	#FFFFFFFF��6>   �� 5:   
   $ 	#FFD9D9D9��6:   �� 5<   
   " ��6+   .�5=      ��  �@J�SnapsToDevicePixels . 64   �� 5>       � ��$	 4,1q�6(   �� 5?       � �� 6;   �� *HorizontalContentAlignment+ �� " ���� 5@       � �� 69   �� *VerticalContentAlignment+ �� " ���� 5A       � ��
 ���� 6+   �� 5B       � ��
 ���� 6,   �� 5C       � ��$ 0q�60   �� 5D       �@�FocusVisualStyle8   61   �� 5E       � �� 5F      �� 5G      " ��6&   .R�5H      �� $ Bd��6!   #��z��6-   #��z��6Y   #��z��6�   # z��6�    . ._�5I      �� #��z��6/   # z 6r   #��z��6�   5J      
 5K      ]� 5L       5M   "   �� 5N   &    �@J�IsMouseOver . 6G   ./�5P   "   �� $ Bd��6?    � �� �	#FF3831316O   5Q      ]� 5R       5S   "   �� 5T   &    �@��IsSelectionActive .  6V   �� 5U   &    �@��
IsSelected . 6F   ./�5W   "   �� $ Bd��6?    � �� �	#FF3831316O   5X      ]� 5Y       5Z   "   �� 5[   &    �@��IsSelectionActive . 6V   �� 5\   &    �@��
IsSelected . 6F   ./�5^   "   �� $ Bd��6?    � �� �	#FF3831316O   5_      P� 5`       � {� .  . �5a   "   �� $ Bd��6K   # � ��6[    � ��5b      5d      5f      5g      �� 5i   
   " ��6'   .�5j      ��  � ��8   6+   �� 5k       � ��8  6,   �� 5l       � ��$ 0q�60   �� 5m       � ��# � ��6+   �� 5n       � ��$ Disabled=�6K   �� 5o       � ��$ Disabled=�6I   �� 5p       � �� .  6>   �� 5q       �@��PanningMode$
 Both=�69   �� 5r       �@��IsFlicksEnabled .  67   �� 5s       � ��$ Center=�69   �� 5t       � �� 5u      �� 5v      " ��6&   .R�5w      �� $ Bd��6!   #��z��6-   #��z��6Y   #��z��6�   $ 0q�6�    . ._�5x      �� |�.  #��z��6=   .��5y   "   �� # z 61   5z      5{      
 5|      P� 5}       � {� .  . �5~   "   �� $ Bd��6?   8   � ��6O   �� 5   "   $ Bd��6@   8   � ��6P   5�      ]� 5�       5�   "   �� 5�   &    �@��
IsGrouping . 6F   �� 5�   &   " �@%�IsVirtualizingWhenGrouping .  6h   ./�5�   "   ��  � �� .  6R   5�      5�      5�      5�      ��5�      	#FFFF9800��6.   ��5�      	#FF252121��69   5�      5�      