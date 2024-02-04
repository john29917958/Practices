<?php

function printVar($var) {
    $valueDesc = "value of variable is: ";
    $typeDesc = "type of variable is: ";
    $type = gettype($var);

    if ($type == "array") {
        echo($valueDesc);
        print_r($var);
        echo("\n");
    } else {
        echo "value of variable is: $var\n";
        echo "type of variable is: $type\n";
    }    
}

echo "=========== Primitive Types ===========\n";

echo "Type: integer\n";
$var = 10;
printVar($var);
echo "\n";

echo "Type: string\n";
$var = "Hello, world!";
printVar($var);
echo "length of \$var is: " . strlen($var) . "\n";
echo "\n";

$var = "Hello!
world!";
echo "value of multi-line string is: $var\n";
echo "\n";

echo "Type: float\n";
$var = 0.1;
printVar($var);
echo "\n";

echo "Type: array\n";
$var = array(1, 2, 3, 4, 5, "arrElem" => "Hello, world!");
printVar($var);
echo "value of \$var[0] is: $var[0]\n";
echo "value of \$var[\"arrElem\"] is: " . $var["arrElem"] . "\n";
echo "size of \$var is: " . count($var) . "\n";
unset($var["arrElem"]);
echo "value of \$var after unset is: \n";
print_r($var);
$var["arrElem"] = "Hello, world!";
echo "value of \$var after setting an element is: \n";
print_r($var);
array_splice($var, 3, 1, array(100));
echo "value of \$var after setting replacing element at index 3 is: \n";
print_r($var);
echo "\n";

/* Supported in PHP 8
echo "Type: enum";
enum Colors
{
    case Red;
    case Green;
    case Blue;
}
echo "1st. Colors value is: " . Colors::Red;
$var = Colors::Red;
echo "Are $var and Color::Red the same? " . ($var == Colors::Red);
echo "Are $var and Color::Green the same? " . ($var == Colors::Green);
echo "\n";
*/

echo "=========== While loop ===========\n";
$var = 10;
while ($var >= 0) {
    echo "value of $var in while loop is: $var\n";
    $var -= 1;    
}

echo "=========== While loop ===========\n";
for ($i = 0; $i < 10; $i++) {
    echo "\$i in for loop is: $i\n";
}
unset($i); // Delete the variable $i as a for loop counter.
echo "\n";

$var = array(0, 1, 2, 3, 4, 5);
foreach ($var as $key => $value) {
    echo "foreach iteration. key: $key, value: $value\n";
}
echo "\n";

class Animal {
    protected $name;
    protected $size;

    function __construct($name, $size) {
        $this->name = $name;
        $this->size = $size;
    }

    public function getName() {
        return $this->name;
    }

    public function setName($name) {
        $this->name = $name;
    }

    public function getSize() {
        return $this->size;
    }

    public function setSize($size) {
        $this->size = $size;
    }

    public function getInfo() {
        return "It's {$this->name}. My size is: {$this->size}\n";
    }
}

$animal = new Animal("It's an animal", 10);
echo("name of animal: {$animal->getName()}\n");
$animal->setName("This is an animal");
echo("name of animal after setting it: {$animal->getName()}\n");
echo($animal->getInfo());

class Human extends Animal {
    private $lastName;

    function __construct($firstName, $lastName, $size) {
        parent::__construct($firstName, $size);
        $this->lastName = $lastName;
    }

    public function getInfo() {
        return "It's {$this->name}, {$this->lastName}. My size is: {$this->size}\n";
    }
}

$animal = new Human("Allen", "Iverson", 50);
echo $animal->getInfo();

?>
