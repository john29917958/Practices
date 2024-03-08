for (let i = 0; i < 10; i++) {
  console.log(`Outer loop: ${i}`);
  for (let i = 0; i < 3; i++) {
    console.log(`Inner loop: ${i}`);
  }
  console.log(`Outer loop: ${i}`);
}
