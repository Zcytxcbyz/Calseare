   M S B A M L   `   `   `  ����   计算扇形面积    Calseare.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  
MainWindow��$	��195��$	��320�� � WindowStyle$
 None=� � AllowsTransparency . 
������  J� OpacityMask
 ����� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � ForceCursor .  � Cursor$ 	Arrow.cur�� � 	Resources    CornerButton	 �� 
TargetType
 �� Property �� Value �� 
TargetType �� RadiusY �� RadiusX J� RenderTransformOrigin �� 
StartPoint �� Opacity �� EndPoint � Color � Offset J� SnapsToDevicePixels �� Triggers P� Property P� Value  TextBox1��%�  &	        &	 �    �� "	 ��.��� 
 � �� �� " ��.R�� .+��� $ 20��$ 20��$ 0.505,-1.444&�
������ ���� $ 0.5,0&�$	 0.5Q�$ 0.5,1&�.��� $ 	#FF085FF7��$ 0Q�� $ 	#FFFDFDFF��$ 1Q��� #��z����. # z #��z��$��计算�� P�  �@J�	IsFocused . P�  �@��IsDefaulted . P�  �@J�IsMouseOver . P�  � �� . P�  � {� .  �� "	 ��.��� 
 � �� �� " ��.R�� .+��� 
������ $ 10��$ 10��
���   �.���� 
���   �$��5q�$
��Left=�$	��195��$��	-1,-1,0,0q�$	��Top=�$	��321�� �� CornerRadius$ 30������  �� Color$ White��$	 0.5Q�._�� $��-5q�.+��� -    ��Name$ CloseButton��$��X��$��350.498,18,-48.498,150q�$
��Bold"�
���  ��
������ 
������ $��18.667(�$ -1.171,0.435&�$��0q� � ToolTip$ Close��z�V� .~���  �� ScaleX$ -1Q��� �� T� �� 
���   �$��2q�$
��Left=�$��24��$	��Top=�$	��162��$��
122,57,0,0q�$ 10��
������ ._��� -    ��Name$ 
TextRadius��$
��Left=�$��24��$��8,0,0,-4q� �� TextWrapping$
 Wrap=�$	��Top=�$	��142��$��0q���Z� ��Z�   �� SelectionBrush  Z� �� 
���   �$��2q�$
��Left=�$��24��$	��Top=�$	��162��$��
122,84,0,0q�$ 10��
������ ._��� -   $ 	TextAngle��$
��Left=�$��24��$��8,0,0,-4q�$
 Wrap=�$	��Top=�$	��142��$��0q���Z� ��Z�   Z� �� -   ! ��Name$! LabelRadius��$��Input radius��$
��Left=�$��23,55.76,0,0q�$	��Top=��� -   $! 
LabelAngle��$��Input degree��$
��Left=�$��	23,84,0,0q�$	��Top=��� -   $! LabelResult��$��Sector area��$
��Left=�$��
10,113,0,0q�$	��Top=�$
��Bold"�
���  ��$ -0.971,0.488&�$��Center=�$	��301���� -   $! Title��$��Calculation sector area��$
��Left=�$��	23,10,0,0q�$	��Top=�$��16(�$
��Bold"��� $��0q�$
��Left=�$��33.76��$��122,138.24,0,0q�$	��Top=�$��94��$ 20������ $ 0.5,1&�$ 0.5,0&�$	 0.5Q�.��� $ 	#FF0245F9��$ 0.017Q�� $ 	#FFFBFBFB��$ 1Q�._��� -	   $ 
MainButton��$��Calculation��$
��Left=�$��	0,0,-1,-1q�$	��Top=�$��93��$��32.76��$��0q�$��13.333(�$
��Bold"���Z� ���� $ Transparent��$ 0Q�