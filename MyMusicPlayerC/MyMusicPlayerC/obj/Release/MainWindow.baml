   M S B A M L   `   `   `  ���� I  EMyMusicPlayerC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MyMusicPlayerCMyMusicPlayerC      MyMusicPlayerC.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:MyMusicPlayerC       � Title$  SmallMediaPlayer��$	��600��$	��800�� � 
ResizeMode$ NoResize=�.��� 
���   � � RowDefinitions �� $��4* ��� $
��0.5* ��� $��1* � � ColumnDefinitions �� $��* ��� $��1* ��� $��1* ��� $��1* ��� $��1* �.+�r� -   $��mediaElement1��$��5��$��0�� r� Stretch$
 Fill=�$��793.6��$��415.2��$��793.6��$��415.2�� r� LoadedBehavior$ Manual=� r� UnloadedBehavior$
 Stop=��� -   $��2��$
��auto��$
��auto��
���   �$��0,0,0,5q�
��� ���.��(� $��48��$��48��.���� $��24��$��24��.+�F� �������! -1� 	=  -1�,  -1�� `q#�� ��р� ��[ Ӏ� ��J ,  	=  	=  	= р��  	= � � ��[ ���!��[ �@o@ z ��� �� �@o@ z � 	=  z � 	= ���`�] ��� �(b��� ��]?�I�`�;�'��/ -1��! -1	
��������� -   $��2��$��1��$
��auto��$
��auto��
���   �$��0,0,0,5q�
���W�.�.��(� $��48��$��48��.���� $��24��$��24��.+�F� ����� �  -1�p�s  -1 	= �e�  	=  � � 	= p�s p�s  	=  �  	= Ӑe�  	=  -1p�s  -1 � � -1�e� �e�  -1 �  -1� � �� ׀�  �  ��� ��� � � ��O ��� ��� ׀�O �  ��� ��� � � ��  ��� ��� ����  �� � $�  � р�� �pr р��  �� 	
��������� -   $��2��$��2��$
��auto��$
��auto��
���   �$��0,0,0,5q�
������.��(� $��48��$��48��.���� $��24��$��24��.+�F� X���Ѐ�� ��!р���!р�@KL р�� @KL ���[ ��!р�� ��!р�� @KL р�[ @KL р�[ ��!	
��������� -   $��2��$��3��$
��auto��$
��auto��
���   �$��0,0,0,5q�
���  ��.��(� $��48��$��48��.���� $��24��$��24��.+�F� 4��������р�[ ��р�[ ��[ р���[ р���	
��������� -   $��2��$��4��$
��auto��$
��auto��
���   �$��0,0,0,5q�
�������.��(� $��48��$��48��.���� $��24��$��24��.+�F� �����`�� �| Ӑ\� �| �ñ @�p �ñ p�b �`�� ��H ��� �� �@�� ��H  ~� ��T  ~� p�b � ~� @�p @�� �| `�� �| �`*� �0�P�B 0�p�G �)�`1� �!��ʛ  u� �P�� ��� �P�� �@� ���j �@� ���j �Ӡ �@� 0K� �p,� �� �0T� �� P�� �B� `��  � ��� p�� � ~�  � p�  �� �� �� р��@� ��F� �@� @V� p�� `�� �5� �@�� `�� QP�� �z�G�0@�P�� ��^��$� ��^��$� �!Ѡ�� PX� �`*� �0�@o@��^���!��^���!��- р�[ ��- р�[ ��� � 	= i� � 	= @B �@o@@B �@o@��^���[ ��^� 	= ��^� 	= ��-р�[ @:4р�[ ��^	
��������� $��1��.+��� 
�������$��Center=�$��8,5,5,5q�$
��Left=�$��Showcard Gothic)�$��18(�	Volume:�� -   $��volumeSlider��$��Center=� � Minimum$ 0Q� � Maximum$ 1Q�	 � Value$		 0.5Q�$��70��$
��Left=�$��10,0,0,0q��� $��1��$��2��.+��� -   
 ��Name$
 Duration��$��1��$��2��
�������$��5q�$��Center=�$��Center=�$��Showcard Gothic)�$��18(�	Seek To�� -	   $��timelineSlider��$��1��$��2�����	#FF0AA0D7