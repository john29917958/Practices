int main(int argc, char *argv[])
{
    // C char type stores an integer that represents to a specific character.
    char character = 'a';
    // So a character can be assigned to a int lvalue. In this case, 97 is assigned to the
    // lvalue, that is, the variable "character_code".
    int character_code = character;

    // A pointer to the starting address of a '\0' null-terminated character sequence.
    const char *c_string = "Hello, world";

    /* Get a lvalue occupying the memory starting from "starting memory address"
       of the character sequence, that is, the address that stores the first character
       in the character sequence. */
    char c0 = *(c_string + 0 * sizeof(c0));
    c0 = c_string[0];
    /* Get a lvalue occupying the memory starting from "starting memory address plus one"
       of the character sequence, that is, the address that stores the second character
       in that character sequence. */
    char c1 = *(c_string + 1 * sizeof(c0));
    c1 = c_string[1];
    /* Get a lvalue occupying the memory starting from "starting memory address plus two"
       of the character sequence, that is, the address that stores the third character
       in that character sequence. */
    char c2 = *(c_string + 2 * sizeof(c0));
    c2 = c_string[2];
    /* Get a lvalue occupying the memory of the ending null character in the memory sequence,
     that is, a '\0' character in the character sequence. */
    char c12 = *(c_string + 12 * sizeof(char));
    c12 = c_string[12];

    /* Get the memory address of the second character by adding
       "size of char multiplied by 1" to the starting memory address,
       dereference it to get the lvalue (locator value), that occupies the identifieable
       memory location of the second character 'e' (101), then get a pointer that points to
       the starting address that this lvalue occupies, and finally, set the value of
       the "c_substring" pointer by the value of the pointer pointing to
       the starting address (a hex memory address) that the lvalue occupies.
     */
    const char *c_substring;
    c_substring = &*(c_string + 1 * sizeof(c0));
    c_substring = &c_string[1];

    return 0;
}