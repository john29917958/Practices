#include <string>

int main(int argc, char *argv[])
{
    // C char type stores an integer that represents to a specific character.
    char character = 'a';
    // So a character can be assigned to a int lvalue. In this case, 97 is assigned to the
    // lvalue, that is, the variable "character_code".
    int character_code = character;

    std::string str = "Hello, world";

    // A pointer to the starting address of a '\0' null-terminated character sequence.
    const char *c_string = str.c_str();

    /* Get the content of the starting memory address,
       that is, the address of first character in the character sequence. */
    char c0 = *(c_string + 0 * sizeof(c0));
    c0 = c_string[0];
    /* Get the content of the "starting memory address plus one",
       that is, the address of second character in that character sequence. */
    char c1 = *(c_string + 1 * sizeof(c0));
    c1 = c_string[1];
    /* Get the content of the "starting memory address plus two",
       that is, the address of third character in that character sequence. */
    char c2 = *(c_string + 2 * sizeof(c0));
    c2 = c_string[2];

    /* Get the memory address of the second character by adding
       "size of char multiplied by 1" to the starting memory address,
       dereference it to get the lvalue (locator value), that occupies the identifieable
       memory location of the second character 'e' (101), then get a pointer that points to
       the starting address that this lvalue occupies, and finally, set the value of
       the "c_substring" pointer by the value of the pointer pointing to
       the starting address (a hex memory address) that the lvalue occupies.
     */
    const char *c_substring = &*(c_string + 1 * sizeof(c0));
    c_substring = &*(c_string + 1 * sizeof(c0));
    c_substring = &c_string[1];

    return 0;
}