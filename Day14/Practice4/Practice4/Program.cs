using Practice4;

var carQueue = new GenericQueue<string>();


carQueue.Enqueue("Ferrari");
carQueue.Enqueue("Porsche");
carQueue.Enqueue("Mercedes");

var (success, peekedCar) = carQueue.Peek();
if (success) Console.WriteLine($"Peeked: {peekedCar}");

var (dequeueSuccess, dequeuedCar) = carQueue.Dequeue();
if (dequeueSuccess) Console.WriteLine($"Dequeued: {dequeuedCar}");
var (dequeueSuccess2, dequeuedCar2) = carQueue.Dequeue();
if (dequeueSuccess2) Console.WriteLine($"Dequeued: {dequeuedCar2}");

var (success2, peekedCar2) = carQueue.Peek();
if (success2) Console.WriteLine($"Peeked: {peekedCar2}");

var (dequeueSuccess3, dequeuedCar3) = carQueue.Dequeue();
if (dequeueSuccess3) Console.WriteLine($"Dequeued: {dequeuedCar3}");

var (dequeueSuccess4, dequeuedCar4) = carQueue.Dequeue();
if (!dequeueSuccess4) Console.WriteLine("Queue is empty, cannot dequeue.");