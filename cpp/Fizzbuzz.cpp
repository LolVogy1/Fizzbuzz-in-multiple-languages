#include <iostream>
#include <string>

int main() {
	std::string fizzBuzz[] = { "Fizz", "Buzz" };
	int multiples[] = { 3, 5 };

	//from 1 to 100
	for (int i = 1; i <= 100; i++) {
		std::string output = "";
		//for each multiple
		for (int j = 0; j <= (sizeof(multiples) / sizeof(*multiples)) - 1; j++) {
			//if a multiple of j
			if (i % multiples[j] == 0) {
				output = output.append(fizzBuzz[j]);
			}
		}
		//if not a multiple of the given numbers
		if (output == "") {
			std::cout << i << "\n";
		}
		else {
			std::cout << output << "\n";
		}
	}
}