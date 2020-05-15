extends KinematicBody2D

var bullet = preload("res://Scene/bullet.tscn")
#var player = preload("res://Scene/Player.tscn")

const MOVE_SPEED = 200
const JUMP_FORCE = 1100
const GRAVITY = 50
const MAX_FALL_SPEED = 500

var vida = 3

var y_velo = 0

onready var rayD = $RayD
onready var rayE = $RayE
onready var sprite = $sprite


func _physics_process(delta):
	var move_dir = 0
	
	if Input.is_action_pressed("move_right"):
		$spaw_bullet.position = Vector2(8,5)
		$sprite.flip_h = false
		$sprite.animation="Walk"
		move_dir += 1
	elif Input.is_action_pressed("move_left"):
		move_dir -= 1
		$spaw_bullet.position = Vector2(-8,5)
		sprite.flip_h = true
		sprite.animation="Walk"
	else:
		sprite.animation="Idle"
	
	if Input.is_action_pressed("shot"):
		spaw_bullet()
	
	var no_chao = rayD.is_colliding() or rayE.is_colliding() 

	if no_chao == false:
		sprite.animation="Jump"
	
	move_and_slide(Vector2(move_dir * MOVE_SPEED, y_velo), Vector2(0, -1))
	
	var grounded = is_on_floor()
	y_velo += GRAVITY
	if grounded and Input.is_action_just_pressed("jump"):
		
		y_velo = -JUMP_FORCE
	if grounded and y_velo >= 0:
		y_velo = 5
	if y_velo > MAX_FALL_SPEED:
		y_velo = MAX_FALL_SPEED
	


func spaw_bullet():
	
	var clone_bullet = bullet.instance()
	get_parent().add_child(clone_bullet)
	clone_bullet.position = $spaw_bullet.global_position
	
	if $sprite.flip_h:
		clone_bullet.linear_velocity = Vector2(-800,0)
	#	$spaw_bullet.position = Vector2(-8,5)
	else:
		clone_bullet.linear_velocity = Vector2(800,0)
	#	$spaw_bullet.position = Vector2(8,5)

func _on_dano_body_entered(body):
	if body.name >= "inimigo":
		vida -= 1
		
	if vida  == 0:
		$sprite.animation = "Die"
		$".".queue_free()
		$"."._init()
		get_tree().reload_current_scene()
