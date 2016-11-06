def reverse(text):
    return EditStrinf(text)[::-1]

def EditStrinf(text):
    punctualtree = (',', '.', ':', '?', '!', ';', '-', '—', '(', ')', '[', ']', '...', "'", '“', '”', '/', ' ')
    for el in punctualtree:
        text = text.replace(el, '')
    text = text.lower()
    return text;

def is_palindrome(text):
    return EditStrinf(text) == reverse(text)

something = input("Enter	text: ")

if is_palindrome(something):
    print("Yes,	it	is	a	palindrome")
else:
    print("No,	it	is	not	a	palindrome")
