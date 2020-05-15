extends Area2D

var game 

func _ready():
	game = get_tree().current_scene

func _on_coin_body_entered(body):
	if body.name == "Player":
		game.score()
		queue_free()

