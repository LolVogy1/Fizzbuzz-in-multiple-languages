
'''Fizzbuzz function'''
def fizzbuzz():
    # Multiples and related strings
    fizz_buzz = ["Fizz", "Buzz"]
    multiples = [3, 5]

    # Loop 0 to 100
    for i in range(0, 100):
        # Empty string
        output = ""
        # Loop through multiples
        for j in range(len(multiples)):
            # If a multiple
            if i % multiples[j] == 0:
                # Add the relevant string
                output = output + (fizz_buzz[j])
        # If the string is empty it is not a multple
        if output == "":
            # Print the number
            print(i)
        else:
            print(output)


if __name__ == "__main__":
    fizzbuzz()
