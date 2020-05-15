extends Node2D

var pontos = 0

func score():
	pontos += 1
	$HUD/score.text = "Score: " + str(pontos)
		
	
