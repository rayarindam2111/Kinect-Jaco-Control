   M S B A M L   `   `   `  ����  SkeletonBasics-WPF8    2Microsoft.Samples.Kinect.SkeletonBasics.taskChoose   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   j   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   -   5          � Title$  MODE Selector��5   	    � 
ResizeMode$ CanMinimize=�6    � WindowStyle$ SingleBorderWindow=�68   $	��257��6�   $	��242��6�    � Icon$< 6/SkeletonBasics-WPF;component/Images/CheckedNormal.png��6  
 � Top$ 30��6w   � Left$	 905��6�  .��5      � $	��202��6   $	��213��6   .+�5   
   �� -   5        $��grpModeSelect��5   c   $��Select MODE��6   $	��190��6(   $
��Left=�65   $��	12,12,0,0q�6P   $	��Top=�6x   $	��189��6�   6�   � 5   
   $��
12,29,12,0q�6    � ColumnDefinitions 5	      �� 5
      $	��30* �6#   �� 5      $
��212* �6#   .+�5      	� -   5        $��
rdoDataset��5   m   $��Create Dataset��6   $��16��63   $
��Left=�6?   $��	24,15,0,0q�6Z   $	��Top=�6   $��2��6�   	� 5      -   5        $��rdoJacoTrain��5   q   $��Jaco Task Training��6   $��16��67   $
��Left=�6C   $��	24,45,0,0q�6^   $	��Top=�6�   $��2��6�   	� 5      -   5        $��rdorunSystem��5   i   $��
Run System��6   $��16��6/   $
��Left=�6;   $��	24,75,0,0q�6V   $	��Top=�6}   $��2��6�   	� 5      -   5        $��rdoPause��5   e   $��Pause��6   $��16��6*   $
��Left=�66   $��
24,106,0,0q�6Q   $	��Top=�6u   $��2��6�   
���  �� d� 	IsChecked$
 TrueY�6�   �� 5      -   5        $��btnModeApply��5   `   $��Apply��6   $��28��6%   $
��Left=�61   $��
82,139,0,0q�6L   $	��Top=�6t   $��77��6�   $��1��6�   6�   5      5      5      